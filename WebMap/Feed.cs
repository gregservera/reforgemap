// The map page's Events panel (Munin Map's event feed, ported): joins, leaves, deaths, chat, pings,
// pins, server notices and the world's events (WorldEvents) in one ordered stream. Kept in memory
// for the page, pushed over the websocket ("events\n[...]"), and appended to events.jsonl beside
// the world data so the history survives a restart ("Show older" reads it back).
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text.RegularExpressions;
using WebMap.Util;

namespace WebMap
{
    internal static class Feed
    {
        public struct Ev
        {
            public long id; public string ts; public string type; public string name; public string text; public float x, z; public bool hasPos;
        }

        private static readonly List<Ev> recent = new List<Ev>();
        private static readonly List<Ev> pending = new List<Ev>();
        private static readonly object gate = new object(), logGate = new object();
        private static long nextId = 1;
        private static volatile string recentJson = "[]";
        private static string dir;

        public static string RecentJson => recentJson;
        private static int Keep => Math.Max(20, WebMapConfig.MAX_MESSAGES);

        public static void Add(string type, string name, string text, float? x = null, float? z = null)
        {
            var ev = new Ev
            {
                ts = DateTime.UtcNow.ToString("o", CultureInfo.InvariantCulture),
                type = type, name = name ?? "", text = text ?? "",
                x = x ?? 0f, z = z ?? 0f, hasPos = x.HasValue && z.HasValue
            };
            lock (gate)
            {
                ev.id = nextId++;
                recent.Add(ev);
                while (recent.Count > Keep) recent.RemoveAt(0);
                pending.Add(ev);
                recentJson = ToJson(recent);
            }
            AppendLog(ev);
        }

        // One of ForgeMap's own feed lines (MapDataServer.AddMessage) as an event: the server's
        // "player _X_ joined/left/died" as a join, leave or death, the rest as chat, a shout, or the
        // server speaking. Whispers never reach the feed.
        public static void FromMessage(int talkerType, string name, string message, bool ev)
        {
            if (ev)
            {
                var m = Regex.Match(message ?? "", @"^player _(.+)_ (joined|left|died)$");
                if (!m.Success) { Add("server", name, message); return; }
                string who = m.Groups[1].Value;
                switch (m.Groups[2].Value)
                {
                    case "joined": Add("join", who, "joined the server"); break;
                    case "left": Add("leave", who, "left the server"); break;
                    default:
                        if (Stats.LastDeath(who, out float dx, out float dz)) Add("death", who, "died", dx, dz);
                        else Add("death", who, "died");
                        break;
                }
                return;
            }
            if (name == WebMapConfig.ANNOUNCE_NAME) { Add("server", name, message); return; }
            Add(talkerType == 2 ? "shout" : "chat", name, message);   // (Talker.Type: 0 whisper, 1 normal, 2 shout)
        }

        // drained by the websocket's tick
        public static string DrainPendingJson()
        {
            lock (gate)
            {
                if (pending.Count == 0) return null;
                string s = ToJson(pending);
                pending.Clear();
                return s;
            }
        }

        private static string ToJson(List<Ev> list)
        {
            var j = new JsonWriter(list.Count * 96 + 16);
            j.BeginArray();
            foreach (var e in list) Write(j, e);
            j.End();
            return j.ToString();
        }

        private static void Write(JsonWriter j, Ev e)
        {
            j.BeginObject().Prop("id", e.id).Prop("ts", e.ts).Prop("type", e.type).Prop("name", e.name).Prop("text", e.text);
            if (e.hasPos) j.Prop("x", e.x, 1).Prop("z", e.z, 1);
            j.End();
        }

        private static void AppendLog(Ev e)
        {
            string d = dir;
            if (string.IsNullOrEmpty(d)) return;
            try
            {
                var j = new JsonWriter(160);
                Write(j, e);
                lock (logGate) File.AppendAllText(Path.Combine(d, "events.jsonl"), j.ToString() + "\n");
            }
            catch { }
        }

        // "Show older": the `limit` events in events.jsonl just before `before` (an ISO time, the
        // oldest the page has), oldest first
        public static string OlderJson(string before, int limit)
        {
            try
            {
                string path = Path.Combine(dir ?? "", "events.jsonl");
                if (dir == null || !File.Exists(path)) return "[]";
                string[] lines;
                lock (logGate) lines = File.ReadAllLines(path);
                var keep = new List<string>();
                for (int i = lines.Length - 1; i >= 0 && keep.Count < limit; i--)
                {
                    string l = lines[i];
                    int k = l.IndexOf("\"ts\":\"", StringComparison.Ordinal);
                    if (k < 0) continue;
                    int end = l.IndexOf('"', k + 6);
                    if (end < 0) continue;
                    if (string.CompareOrdinal(l.Substring(k + 6, end - k - 6), before) < 0) keep.Add(l);
                }
                keep.Reverse();
                return "[" + string.Join(",", keep) + "]";
            }
            catch (Exception e) { ZLog.LogWarning("WebMap: older events: " + e.Message); return "[]"; }
        }

        // the world is loaded: the end of its log, so the panel is not empty after a restart
        public static void Load(string worldDataPath)
        {
            lock (gate)
            {
                dir = worldDataPath;
                recent.Clear(); pending.Clear();
                try
                {
                    string path = Path.Combine(dir, "events.jsonl");
                    if (File.Exists(path))
                    {
                        var lines = File.ReadAllLines(path);
                        for (int i = Math.Max(0, lines.Length - Keep); i < lines.Length; i++)
                        {
                            if (string.IsNullOrWhiteSpace(lines[i])) continue;
                            Dictionary<string, object> d = null;
                            try { d = JsonParser.Parse(lines[i]) as Dictionary<string, object>; } catch { }   // one bad line must not drop the rest
                            if (d == null) continue;
                            recent.Add(new Ev
                            {
                                id = nextId++, ts = JsonParser.Str(d, "ts"), type = JsonParser.Str(d, "type"),
                                name = JsonParser.Str(d, "name"), text = JsonParser.Str(d, "text"),
                                hasPos = d.ContainsKey("x"), x = (float)JsonParser.Num(d, "x"), z = (float)JsonParser.Num(d, "z")
                            });
                        }
                    }
                }
                catch (Exception e) { ZLog.LogWarning("WebMap: events.jsonl not readable: " + e.Message); }
                recentJson = ToJson(recent);
            }
        }

        // ---------- for the tests ----------
        internal static void ResetForTests(string worldDataPath) { Load(worldDataPath); DrainPendingJson(); }
    }
}
