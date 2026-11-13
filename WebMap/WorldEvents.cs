// What happens in the world, for the map's Events panel (Feed) and the server's Discord (Munin Map's
// Live/WorldEvents, ported; ticket fonctions-munin-hors-carte):
//   - raids: the server runs them (RandEventSystem.m_randomEvent), so a loop here sees one start and end;
//   - invasions: the game's other kind of event (PersistentEventSystem), a site that stays an hour or two;
//   - boss kills: the killer's game sends the server "SetGlobalKey defeated_<boss>" (every kill, not
//     only the first), which the routed RPC observer (WebMap.cs) hands to OnGlobalKey;
//   - finds: a boss altar, trader or mini boss the moment its ground is explored;
//   - a player's first steps in a biome; everyone sleeping through the night.
// The raid and invasions on now also go to the map, which draws them as the game does (raid.js).
//
// Only players who share their position are named near a raid, a kill or a find, and only their
// biomes are followed: the feed must not say where a hidden player is.
using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using UnityEngine;
using WebMap.Util;

namespace WebMap
{
    internal static class WorldEvents
    {
        public static readonly int SetGlobalKeyHash = "SetGlobalKey".GetStableHashCode();

        private static readonly Dictionary<string, string> Bosses = new Dictionary<string, string>
        {
            { "defeated_eikthyr", "Eikthyr" }, { "defeated_gdking", "The Elder" }, { "defeated_bonemass", "Bonemass" },
            { "defeated_dragon", "Moder" }, { "defeated_goblinking", "Yagluth" }, { "defeated_queen", "The Queen" },
            { "defeated_fader", "Fader" },
            { "defeated_frozenking", "Kall Fimbulbringer's first form" }, { "defeated_frozenking_p3", "Kall Fimbulbringer" },
        };
        // rare creatures, not bosses, though the game sets a "defeated_" key for them too
        internal static readonly HashSet<string> NotBosses = new HashSet<string> { "writhan", "elakingmole" };
        private static readonly Dictionary<string, float> lastKill = new Dictionary<string, float>();

        // to the Events panel, and to Discord when it is news for the whole server
        private static void Tell(string type, string name, string text, Vector3? at, string discord = null)
        {
            if (at.HasValue) Feed.Add(type, name, text, at.Value.x, at.Value.z);
            else Feed.Add(type, name, text);
            if (discord != null)
                try { WebMap.instance?.discordWebHook?.SendMessage(discord); } catch { }
        }

        // ---- boss kills (main thread: the RPC observer runs there)
        public static void OnGlobalKey(ZRoutedRpc.RoutedRPCData data)
        {
            try
            {
                var pkg = new ZPackage(data.m_parameters.GetArray());   // a copy: the game still reads the original
                string key = BossKey(pkg.ReadString());
                if (key == null) return;
                // one kill can reach the server more than once (several players own parts of the fight)
                float now = Time.realtimeSinceStartup;
                if (lastKill.TryGetValue(key, out float t) && now - t < 60f) return;
                lastKill[key] = now;
                string boss = BossName(key);
                ZNetPeer peer = ZNet.instance != null ? ZNet.instance.GetPeer(data.m_senderPeerID) : null;
                bool seen = peer != null && Shares(peer);
                string who = peer != null ? Names(NearbyPeers(peer.m_refPos, peer)) : "";
                string text = "was defeated" + (who.Length > 0 ? " by " + who : "");
                Tell("boss", boss, text, seen ? peer.m_refPos : (Vector3?)null, "🏆 " + boss + " " + text);
            }
            catch (Exception e) { ZLog.LogWarning("WebMap: boss event: " + e.Message); }
        }

        // "defeated_<boss>" from a SetGlobalKey's text ("key" or "key value"), lower case; null for
        // any other key and for the rare creatures that are not bosses
        internal static string BossKey(string raw)
        {
            string key = (raw ?? "").Trim().ToLowerInvariant();
            int sp = key.IndexOf(' ');
            if (sp > 0) key = key.Substring(0, sp);
            if (!key.StartsWith("defeated_", StringComparison.Ordinal) || key.Length == 9 || NotBosses.Contains(key.Substring(9))) return null;
            return key;
        }
        internal static string BossName(string key) => Bosses.TryGetValue(key, out string b) ? b : Pretty(key.Substring(9));

        // ---- raids and invasions, every 2 s
        // the raid on now: {"name","x","z","r","since","near"}, or null; the invasions [{"id","name","x","z","r","left"?,"age"?}]
        public static volatile string RaidJson = "null";
        public static volatile string InvasionsJson = "[]";

        public static IEnumerator RaidLoop()
        {
            string current = null, endText = null;
            while (true)
            {
                try
                {
                    var rs = RandEventSystem.instance;
                    var ev = rs != null ? rs.m_randomEvent : null;
                    string name = ev != null ? ev.m_name : null;
                    if (name != current)
                    {
                        if (current != null) Tell("raid", "Raid", endText ?? "is over", null, "⚔️ Raid: " + (endText ?? "is over"));
                        RaidJson = "null";
                        if (ev != null)
                        {
                            Vector3 p = ev.m_pos;
                            string start = Tiles.Live.WorldEvents.Localize(ev.m_startMessage, Pretty(ev.m_name));
                            string who = Names(NearbyPeers(p, null, 150f));
                            // a raid the world was saved with, going on again after a restart, has its time
                            // so far: it was told when it began
                            bool resumed = ev.m_time > 10f;
                            string text = start + (who.Length > 0 ? " (near " + who + ")" : "");
                            if (!resumed) Tell("raid", "Raid", text, p, "⚔️ Raid: " + text);
                            endText = Tiles.Live.WorldEvents.Localize(ev.m_endMessage, "is over");
                            RaidJson = new JsonWriter(200).BeginObject().Prop("name", start).Prop("x", p.x, 1).Prop("z", p.z, 1).Prop("r", ev.m_eventRange, 0)
                                .Prop("since", DateTimeOffset.UtcNow.ToUnixTimeSeconds() - (resumed ? (long)ev.m_time : 0L)).Prop("near", who).End().ToString();
                        }
                        current = name;
                    }
                }
                catch (Exception e) { if (WebMapConfig.DEBUG) ZLog.LogWarning("WebMap: raid check: " + e.Message); }
                try { CheckInvasions(); }
                catch (Exception e) { if (WebMapConfig.DEBUG) ZLog.LogWarning("WebMap: invasion check: " + e.Message); }
                yield return new WaitForSeconds(2f);
            }
        }

        // When each invasion began, on the world's clock: the game leaves it unset, so it is the first
        // time this saw it, kept in invasions.txt ("id<TAB>x<TAB>z<TAB>began", -1: on before this was
        // watching) so a restart does not lose it. The game numbers them again from 0 once none are
        // on, so the spot tells them apart.
        private static readonly Dictionary<int, string> invasionNames = new Dictionary<int, string>();
        private static readonly Dictionary<int, double[]> invasionSeen = new Dictionary<int, double[]>();
        private static bool invasionsLoaded;
        private static string InvasionsPath => Path.Combine(WebMap.worldDataPath ?? "", "invasions.txt");

        private static void CheckInvasions()
        {
            var ps = PersistentEventSystem.instance;
            var list = ps != null && ps.m_activePersistentEvents != null ? ps.m_activePersistentEvents.list : null;
            double now = ZNet.instance != null ? ZNet.instance.GetTimeSeconds() : 0;
            bool first = false;
            if (!invasionsLoaded && now > 1 && list != null && WebMap.worldDataPath != null) { LoadInvasions(); invasionsLoaded = first = true; }
            bool changed = false;
            var j = new JsonWriter(256).BeginArray();
            var on = new HashSet<int>();
            if (list != null)
                foreach (var ev in list)
                {
                    on.Add(ev.eventId);
                    bool isNew = false;
                    if (invasionsLoaded && !(invasionSeen.TryGetValue(ev.eventId, out var seen) && Mathf.Abs((float)seen[0] - ev.position.x) < 1f && Mathf.Abs((float)seen[1] - ev.position.z) < 1f))
                    {
                        isNew = !first;
                        invasionSeen[ev.eventId] = new double[] { ev.position.x, ev.position.z, ev.startTime > 0 ? ev.startTime : first ? -1 : now };
                        changed = true;
                    }
                    if (!invasionNames.TryGetValue(ev.eventId, out string name))
                    {
                        string token = null, fallback = null;
                        try { token = ev.Source.mapTokenString; } catch { }
                        try { fallback = Pretty(ev.internalName); } catch { }
                        name = Tiles.Live.WorldEvents.Localize(token, fallback ?? "Invasion");
                        invasionNames[ev.eventId] = name;
                    }
                    if (isNew)
                    {
                        string who = Names(NearbyPeers(ev.position, null, ev.radius + 150f));
                        string text = "has begun" + (who.Length > 0 ? " (near " + who + ")" : "");
                        Tell("invasion", name, text, ev.position, "🔥 " + name + " " + text);
                    }
                    double began = ev.startTime > 0 ? ev.startTime : invasionSeen.TryGetValue(ev.eventId, out var b) ? b[2] : -1;
                    j.BeginObject().Prop("id", ev.eventId).Prop("name", name).Prop("x", ev.position.x, 1).Prop("z", ev.position.z, 1).Prop("r", ev.radius, 0);
                    if (ev.duration >= 0 && ev.startTime > 0) j.Prop("left", Math.Max(0, ev.startTime + ev.duration - now), 0);
                    if (began >= 0 && now >= began) j.Prop("age", now - began, 0);
                    j.End();
                }
            foreach (int id in new List<int>(invasionNames.Keys))
                if (!on.Contains(id))
                {
                    Tell("invasion", invasionNames[id], "is over", null, "🔥 " + invasionNames[id] + " is over");
                    invasionNames.Remove(id);
                }
            if (invasionsLoaded && list != null)
                foreach (int id in new List<int>(invasionSeen.Keys))
                    if (!on.Contains(id)) { invasionSeen.Remove(id); changed = true; }
            if (changed) SaveInvasions();
            InvasionsJson = j.End().ToString();
        }

        private static void LoadInvasions()
        {
            invasionSeen.Clear();
            try
            {
                if (!File.Exists(InvasionsPath)) return;
                foreach (var line in File.ReadAllLines(InvasionsPath))
                {
                    var t = line.Split('\t');
                    if (t.Length == 4 && int.TryParse(t[0], out int id)
                        && double.TryParse(t[1], NumberStyles.Float, CultureInfo.InvariantCulture, out double x)
                        && double.TryParse(t[2], NumberStyles.Float, CultureInfo.InvariantCulture, out double z)
                        && double.TryParse(t[3], NumberStyles.Float, CultureInfo.InvariantCulture, out double began))
                        invasionSeen[id] = new[] { x, z, began };
                }
            }
            catch (Exception e) { ZLog.LogWarning("WebMap: invasions state: " + e.Message); }
        }

        private static void SaveInvasions()
        {
            try
            {
                var sb = new StringBuilder();
                var inv = CultureInfo.InvariantCulture;
                foreach (var kv in invasionSeen)
                    sb.Append(kv.Key).Append('\t').Append(kv.Value[0].ToString("0.#", inv)).Append('\t').Append(kv.Value[1].ToString("0.#", inv)).Append('\t').Append(kv.Value[2].ToString("0.#", inv)).Append('\n');
                File.WriteAllText(InvasionsPath, sb.ToString());
            }
            catch (Exception e) { ZLog.LogWarning("WebMap: invasions state: " + e.Message); }
        }

        // ---- finds and biomes, every 3 s. Remembered in world-events.txt beside the world's map data, so
        // a restart does not tell them again. The first time (no file yet), what is already explored
        // counts as found and the players the map knows as having been in every biome explored so
        // far: only what happens from then on is news.
        private static List<Tiles.Markers.Findable> findables;
        private static int findablesAge;
        private static readonly HashSet<string> found = new HashSet<string>();
        private static readonly HashSet<string> seededKinds = new HashSet<string>();
        private static readonly Dictionary<string, HashSet<string>> biomes = new Dictionary<string, HashSet<string>>();
        private static HashSet<string> worldBiomes;
        private static bool loaded, seeding;
        private static string StatePath => Path.Combine(WebMap.worldDataPath ?? "", "world-events.txt");

        private static void Load()
        {
            loaded = true;
            seeding = !File.Exists(StatePath);
            if (seeding) return;
            try
            {
                foreach (var line in File.ReadAllLines(StatePath))
                {
                    var t = line.Split('\t');
                    if (t.Length >= 2 && t[0] == "found") found.Add(t[1]);
                    else if (t.Length == 2 && t[0] == "kind") seededKinds.Add(t[1]);
                    else if (t.Length == 3 && t[0] == "biomes") biomes[t[1]] = new HashSet<string>(t[2].Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries));
                }
            }
            catch (Exception e) { ZLog.LogWarning("WebMap: world events state: " + e.Message); }
        }

        private static void Save()
        {
            try
            {
                var sb = new StringBuilder();
                foreach (var f in found) sb.Append("found\t").Append(f).Append('\n');
                foreach (var k in seededKinds) sb.Append("kind\t").Append(k).Append('\n');
                foreach (var kv in biomes) sb.Append("biomes\t").Append(kv.Key.Replace('\t', ' ')).Append('\t').Append(string.Join(",", kv.Value)).Append('\n');
                File.WriteAllText(StatePath, sb.ToString());
            }
            catch (Exception e) { ZLog.LogWarning("WebMap: world events state: " + e.Message); }
        }

        private static string BiomeAt(float x, float z) => Tiles.Palette.BiomeName((int)WorldGenerator.instance.GetBiome(x, z));

        // the biomes of explored ground (a coarse look over the fog), for the first run
        private static HashSet<string> ExploredBiomes()
        {
            var set = new HashSet<string>();
            try
            {
                for (float x = -10400; x <= 10400; x += 48)
                    for (float z = -10400; z <= 10400; z += 48)
                        if (x * x + z * z < 10500f * 10500f && MapFog.IsExplored(x, z)) set.Add(BiomeAt(x, z));
            }
            catch { }
            return set;
        }

        public static IEnumerator DiscoveryLoop()
        {
            yield return new WaitForSeconds(20f);   // the world, the fog and the first sweep first
            while (true)
            {
                try { Discover(); } catch (Exception e) { if (WebMapConfig.DEBUG) ZLog.LogWarning("WebMap: discovery: " + e.Message); }
                yield return new WaitForSeconds(3f);
            }
        }

        private static void Discover()
        {
            if (WebMap.worldDataPath == null || WorldGenerator.instance == null) return;
            if (!loaded) Load();
            bool changed = false, anyFound = false;
            // read again now and then: locations get built as people explore
            if (findables == null || findables.Count == 0 || ++findablesAge >= 10) { findables = Tiles.Markers.Findables(); findablesAge = 0; }
            foreach (var f in findables)
            {
                if (found.Contains(f.key) || !MapFog.IsExplored(f.pos.x, f.pos.z)) continue;
                found.Add(f.key); changed = anyFound = true;
                // quiet for a kind this world has not tracked before (what was explored when it came is not news)
                if (seeding || !seededKinds.Contains(f.kind)) continue;
                string who = Names(NearbyPeers(f.pos, null, 200f));
                string what = f.kind == "boss" ? f.label + "'s altar" : f.kind == "trader" ? f.label + "'s camp" : f.label;
                string text = "found" + (who.Length > 0 ? " by " + who : "");
                Tell("found", what, text, f.pos, "🧭 " + what + " " + text);
            }
            foreach (var f in findables) if (seededKinds.Add(f.kind)) changed = true;
            if (anyFound && !seeding) Tiles.Markers.Refresh();

            if (seeding && worldBiomes == null)
            {
                worldBiomes = ExploredBiomes();
                foreach (var k in Stats.Names()) if (!biomes.ContainsKey(k)) biomes[k] = new HashSet<string>(worldBiomes);
                changed = true;
            }
            foreach (var p in ZNet.instance.GetPeers())
            {
                if (p == null || p.m_server || string.IsNullOrEmpty(p.m_playerName) || !Shares(p)) continue;
                Vector3 at = p.m_refPos;
                if (at.sqrMagnitude < 1f) continue;                // not placed yet
                string b = BiomeAt(at.x, at.z);
                if (string.IsNullOrEmpty(b) || b == "Ocean" || b == "Unknown") continue;
                if (!biomes.TryGetValue(p.m_playerName, out var seen)) { biomes[p.m_playerName] = seen = new HashSet<string>(); changed = true; }
                if (!seen.Add(b)) continue;
                changed = true;
                // a new player's first steps are in the Meadows: no news
                if (!seeding && b != "Meadows") Tell("biome", p.m_playerName, "entered the " + b + " for the first time", at);
            }
            seeding = false;
            if (changed) Save();
        }

        // ---- everyone slept (EnvMan.SkipToMorning runs on the server when every player is in bed)
        [HarmonyLib.HarmonyPatch(typeof(EnvMan), nameof(EnvMan.SkipToMorning))]
        private class SkipToMorningPatch
        {
            private static void Postfix()
            {
                try
                {
                    double t = ZNet.instance != null ? ZNet.instance.GetTimeSeconds() : 0;
                    float dayLen = EnvMan.instance != null ? EnvMan.instance.m_dayLengthSec : 1800f;
                    // the day it skips to: the next one when slept before midnight, this one after
                    int day = (int)(t / dayLen) + (t % dayLen > dayLen * 0.5 ? 1 : 0);
                    Feed.Add("sleep", "Everyone slept", "through the night, day " + day + " begins");
                }
                catch (Exception e) { ZLog.LogWarning("WebMap: sleep event: " + e.Message); }
            }
        }

        // a player the map may place
        private static bool Shares(ZNetPeer p) => p.m_publicRefPos || WebMapConfig.ALWAYS_VISIBLE;

        // the players within `within` m of a spot who share their position, closest first (the sender first)
        private static List<string> NearbyPeers(Vector3 pos, ZNetPeer sender, float within = 100f)
        {
            var near = new List<KeyValuePair<float, string>>();
            try
            {
                foreach (var p in ZNet.instance.GetPeers())
                {
                    if (p == null || string.IsNullOrEmpty(p.m_playerName) || !Shares(p)) continue;
                    float d = p == sender ? -1f : Vector3.Distance(p.m_refPos, pos);
                    if (d <= within) near.Add(new KeyValuePair<float, string>(d, p.m_playerName));
                }
            }
            catch { }
            near.Sort((a, b) => a.Key.CompareTo(b.Key));
            return near.ConvertAll((kv) => kv.Value);
        }

        // "A", "A and B", "A, B and C"
        internal static string Names(List<string> list) =>
            list.Count <= 1 ? (list.Count == 1 ? list[0] : "") : string.Join(", ", list.GetRange(0, list.Count - 1)) + " and " + list[list.Count - 1];

        // "army_theelder" -> "Army theelder": readable enough for an event without a message
        internal static string Pretty(string s)
        {
            if (string.IsNullOrEmpty(s)) return "Something";
            s = s.Replace('_', ' ').Trim();
            return char.ToUpperInvariant(s[0]) + s.Substring(1);
        }
    }
}
