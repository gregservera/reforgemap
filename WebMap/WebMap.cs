using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using BepInEx;
using HarmonyLib;
using UnityEngine;
using static ZRoutedRpc;
using Random = UnityEngine.Random;
using System.Collections;

// the tests reach the internal static classes directly: WebMap.Tests
[assembly: System.Runtime.CompilerServices.InternalsVisibleTo("WebMap.Tests")]

namespace WebMap
{
    [BepInPlugin(GUID, NAME, VERSION)]
    public class WebMap : BaseUnityPlugin
    {
        // ForgeMap's own since 1.1.0 (WebMap's was com.github.h0tw1r3.valheim.webmap). BepInEx
        // names the config file after it: Migration copies WebMap's over on the first start.
        public const string GUID = "fr.forgeserver.forgemap";
        public const string NAME = "ForgeMap";
        public const string VERSION = Manifest.Version;        // manifest.json's, compiled in by WebMap.csproj

        internal static readonly string[] ALLOWED_PINS = { "dot", "fire", "mine", "house", "cave" };

        public DiscordWebHook discordWebHook;
        public static MapDataServer mapDataServer;
        public static string worldDataPath;
        public static string mapDataPath;
        public static string pluginPath;

        public static int sayMethodHash = 0;
        public static int chatMessageMethodHash = 0;

        public static bool fogTextureNeedsSaving;

        public static string currentWorldName;
        public static Dictionary<string, object> serverInfo;

        private static Harmony harmony;

        public static WebMap instance;

        //The Awake() method is run at the very start when the game is initialized.
        public void Awake()
        {
            instance = this;
            pluginPath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);

            // From WebMap (or ForgeMap 1.0, which still ran as WebMap): its config and its map
            // data, copied before either is read. Then the warning should WebMap load as well.
            string pluginsRoot = Paths.PluginPath;
            if (string.IsNullOrEmpty(pluginsRoot)) pluginsRoot = Path.GetDirectoryName(pluginPath ?? "");
            if (Migration.Run(Config.ConfigFilePath, pluginsRoot, pluginPath ?? "")) Config.Reload();
            if (BepInEx.Bootstrap.Chainloader.PluginInfos.ContainsKey(Migration.OldGuid))
                ZLog.LogWarning("ForgeMap: WebMap is loaded as well: both would serve a map on the same port. Remove WebMap, ForgeMap replaces it.");

            harmony = new Harmony(GUID);
            harmony.PatchAll(Assembly.GetExecutingAssembly());

            mapDataPath = Path.Combine(pluginPath ?? string.Empty, "map_data");
            Directory.CreateDirectory(mapDataPath);

            WebMapConfig.ReadConfigFile(Config);
            Settings.Load(mapDataPath);                       // what admins set on the site lies over the config
            // the operator's switch for small servers has the last word, over the site's settings too
            foreach (string line in WebMapConfig.ApplyLightMode()) ZLog.Log("ForgeMap: light mode: " + line);

            discordWebHook = new DiscordWebHook(WebMapConfig.DISCORD_WEBHOOK);
            ServerLog.Listen();                               // from the start: the game's startup lines too
        }

        public void OnDestroy()
        {
             Config.Save();
        }

        public void Online()
        {
            StaticCoroutine.Start(SaveFogTextureLoop());
            StaticCoroutine.Start(UpdateFogTextureLoop());
            StaticCoroutine.Start(StructureMap.Loop());
            StaticCoroutine.Start(Announce.Pump());
            StaticCoroutine.Start(PlayerSnapshotLoop());
            // the 3D view: models exported a few a frame as the sweep meets new prefabs,
            // and the fallback for height sampling should the engine want it on this thread
            if (WebMapConfig.EXPORT_MODELS) StaticCoroutine.Start(Models.ModelStore.Pump());
            StaticCoroutine.Start(Heights.Pump());
            ChatRelay.Start();          // Discord -> game, its own pool-thread timer
            // the map tiles: the workers, the game-thread fallback for terrain sampling, and the
            // close-zoom tiles over everything already walked (only what is missing is queued)
            StaticCoroutine.Start(Tiles.TileStore.MainThreadPump());
            Tiles.TileStore.Start();
            Tiles.BiomeMap.Start(worldDataPath);          // the biomes map and grid, once per world, on a worker
            StaticCoroutine.Start(Tiles.Runestones.PrepareRoutine(mapDataPath));   // what each runestone says, once
            StaticCoroutine.Start(Tiles.Markers.LiveLoop());                        // portals and boats between sweeps
            StaticCoroutine.Start(WorldEvents.RaidLoop());                          // raids and invasions, for the Events panel and the map
            StaticCoroutine.Start(WorldEvents.DiscoveryLoop());
            StaticCoroutine.Start(Tiles.WorldPicture.Loop());                       // /map from the tiles, made again as they change
            Tiles.MapIcons.Start(mapDataPath);            // the game's own map icons and item icons, cut from its files once
            Tiles.ItemIcons.Start(mapDataPath);                     // altars and traders found, first steps in a biome
            Feed.Add("server", "Server", "online");
            int stride = Math.Max(1, (int)(Tiles.TileMath.TileSpanMeters(WebMapConfig.PRERENDER_ZOOM + 1) / WebMapConfig.PIXEL_SIZE / 2));
            MapFog.ForEachExplored(Tiles.TileStore.OnExplored, stride);
            NotifyOnline();
        }

        public void SetServerInfo(bool openServer, bool publicServer, string serverName, string password, string worldName, string worldSeed)
        {
            serverInfo = new Dictionary<string, object>();
            serverInfo.Add("openServer", openServer);
            serverInfo.Add("publicServer", publicServer);
            serverInfo.Add("serverName", serverName);
            serverInfo.Add("password", password);
            serverInfo.Add("worldName", worldName);
            serverInfo.Add("worldSeed", worldSeed);
        }

        public void NotifyOnline()
        {
            discordWebHook.SendMessage($"🎮 **{serverInfo["serverName"]}** is *online* 🟢\n💻 {AccessTools.Method(typeof(ZNet), "GetServerIP").Invoke(ZNet.instance, new object[] { })}:{ZNet.instance.GetHostPort()}\n🔑 {serverInfo["password"]}\n🗺 {WebMapConfig.URL}");
        }

        public void NotifyOffline()
        {
            discordWebHook.SendMessage($"🎮 **{serverInfo["serverName"]}** is *offline* 🔴");
        }

        public void NotifyJoin(ZNetPeer peer)
        {
            string message = $"player _{peer.m_playerName}_ joined";
            Stats.Join(peer.m_playerName);
            discordWebHook.SendMessage($"🎮 **{serverInfo["serverName"]}** {message}");
            mapDataServer.AddMessage(peer.m_uid, (int)Talker.Type.Normal, "Server", message, true);
        }

        public void NotifyLeave(ZNetPeer peer)
        {
            string message = $"player _{peer.m_playerName}_ left";
            Stats.Leave(peer.m_playerName);
            discordWebHook.SendMessage($"🎮 **{serverInfo["serverName"]}** {message}");
            // MessageHud is a client HUD; on a dedicated server instance is null, so
            // this threw on every disconnect. Announce.Enqueue reaches players properly.
            // feed: false -- the line below is this leave's one feed entry. Announcing
            // it as well wrote a second, and every disconnect showed up twice.
            Announce.Enqueue(message, false);
            mapDataServer.AddMessage(peer.m_uid, (int)Talker.Type.Normal, "Server", message, true);
        }

        public void NewWorld()
        {
            string worldName = WebMapConfig.GetWorldName();
            bool forceReload = (currentWorldName != worldName);

            worldDataPath = Path.Combine(mapDataPath, WebMapConfig.GetWorldName());
            Directory.CreateDirectory(worldDataPath);
            Stats.Load(worldDataPath);
            Trails.Load(worldDataPath);
            Chart.Load(worldDataPath);
            Features.Load(worldDataPath);
            Feed.Load(worldDataPath);
            Activity.Load(worldDataPath);                 // the Activity layers' zone totals
            Tiles.BuildHistory.Load(worldDataPath);       // and New building, Lag hotspots
            Tiles.Hotspots.Load(worldDataPath);                     // the map's Events panel: the end of its log
            ServerLog.Open(worldDataPath);                // the game's console lines, for admins
            Portals.Load(worldDataPath);
            Locations.Load(worldDataPath);
            // Munin's map tiles: the trees the last sweep saw, then what is drawn already
            Tiles.Vegetation.LoadCache(worldDataPath);
            Tiles.Structures.LoadCache(worldDataPath);
            Tiles.Ruins.LoadCache(worldDataPath);
            Tiles.Markers.LoadOverrides(worldDataPath);    // Munin's markers: base names, and what the last sweep published
            Tiles.Markers.LoadCache(worldDataPath);
            Tiles.Peaks.Start(worldDataPath);
            Tiles.TileStore.Init(worldDataPath);
            Tiles.WorldPicture.Load(worldDataPath);       // the one picture of the world (/map), as last made
            // prefabs are the same in every world, so the model library sits beside the worlds
            if (Models.ModelStore.Root == null) Models.ModelStore.Init(mapDataPath);

            if (mapDataServer == null)
            {
                ZLog.Log($"WebMap: loading existing world: #{worldName}");
                mapDataServer = new MapDataServer();
            }
            else if (forceReload)
            {
                ZLog.Log($"WebMap: loading a new world! old: #{currentWorldName} new: #{worldName}");
            }

            currentWorldName = worldName;

            string fogImagePath = Path.Combine(worldDataPath, "fog.png");
            try
            {
                Texture2D fogTexture = new Texture2D(WebMapConfig.TEXTURE_SIZE, WebMapConfig.TEXTURE_SIZE);
                byte[] fogBytes = File.ReadAllBytes(fogImagePath);
                ImageConv.LoadImage(fogTexture, fogBytes);
                mapDataServer.SetFog(fogTexture, fresh: false);
                UnityEngine.Object.Destroy(fogTexture);
            }
            catch (Exception e)
            {
                ZLog.LogWarning("WebMap: Failed to read fog image data from disk... Making new fog image..." + e.Message);
                Texture2D fogTexture = new Texture2D(WebMapConfig.TEXTURE_SIZE, WebMapConfig.TEXTURE_SIZE,
                    TextureFormat.R8, false);
                Color32[] fogColors = new Color32[WebMapConfig.TEXTURE_SIZE * WebMapConfig.TEXTURE_SIZE];
                for (int t = 0; t < fogColors.Length; t++) fogColors[t] = Color.black;

                fogTexture.SetPixels32(fogColors);
                byte[] fogPngBytes = ImageConv.EncodeToPNG(fogTexture);

                mapDataServer.SetFog(fogTexture, fresh: true);
                UnityEngine.Object.Destroy(fogTexture);
                try
                {
                    File.WriteAllBytes(fogImagePath, fogPngBytes);
                }
                catch (Exception ex)
                {
                    ZLog.LogError("WebMap: FAILED TO WRITE FOG FILE! " + ex.Message);
                }
            }

            string mapPinsFile = Path.Combine(worldDataPath, "pins.csv");
            try
            {
                string[] pinsLines = File.ReadAllLines(mapPinsFile);
                mapDataServer.pins = new List<string>(pinsLines);
            }
            catch (Exception e)
            {
                ZLog.LogError("WebMap: Failed to read pins.csv from disk. " + e.Message);
            }

            if (forceReload)
            {
                mapDataServer.Reload();
            }
        }

        // The broadcast timer and every HTTP request used to read ZDOs and ZNet's
        // peer list themselves, from whatever thread they happened to be on. They
        // read what this builds instead.
        public IEnumerator PlayerSnapshotLoop()
        {
            while (true)
            {
                mapDataServer.RefreshPlayerSnapshot();
                yield return new WaitForSeconds(WebMapConfig.PLAYER_UPDATE_INTERVAL);
            }
        }

        public IEnumerator UpdateFogTextureLoop()
        {
            while(true)
            {
                yield return new WaitForSeconds(WebMapConfig.UPDATE_FOG_TEXTURE_INTERVAL);
                UpdateFogTexture();
            }
        }

        public void UpdateFogTexture()
        {
            int pixelExploreRadius = (int)Mathf.Ceil(WebMapConfig.EXPLORE_RADIUS / WebMapConfig.PIXEL_SIZE);
            int pixelExploreRadiusSquared = pixelExploreRadius * pixelExploreRadius;
            int halfTextureSize = WebMapConfig.TEXTURE_SIZE / 2;

            bool changed = false;
            mapDataServer.players.ForEach(player =>
            {
                if (player.m_publicRefPos || WebMapConfig.ALWAYS_MAP || WebMapConfig.ALWAYS_VISIBLE)
                {
                    ZDO zdoData = null;
                    try
                    {
                        zdoData = ZDOMan.instance.GetZDO(player.m_characterID);
                    }
                    catch { }

                    if (zdoData != null)
                    {
                        Vector3 pos = zdoData.GetPosition();
                        int pixelX = Mathf.RoundToInt(pos.x / WebMapConfig.PIXEL_SIZE + halfTextureSize);
                        int pixelY = Mathf.RoundToInt(pos.z / WebMapConfig.PIXEL_SIZE + halfTextureSize);
                        for (int y = pixelY - pixelExploreRadius; y <= pixelY + pixelExploreRadius; y++)
                        {
                            for (int x = pixelX - pixelExploreRadius; x <= pixelX + pixelExploreRadius; x++)
                                if (y >= 0 && x >= 0 && y < WebMapConfig.TEXTURE_SIZE &&
                                    x < WebMapConfig.TEXTURE_SIZE)
                                {
                                    int xDiff = pixelX - x;
                                    int yDiff = pixelY - y;
                                    int currentExploreRadiusSquared = xDiff * xDiff + yDiff * yDiff;
                                    if (currentExploreRadiusSquared < pixelExploreRadiusSquared)
                                    {
                                        byte[] fog = mapDataServer.fogRgba;
                                        int o = (y * WebMapConfig.TEXTURE_SIZE + x) * 4;
                                        if (fog != null && fog[o] != 255)
                                        {
                                            if (WebMapConfig.DEBUG && !fogTextureNeedsSaving) ZLog.Log("Fog needs saving");
                                            fogTextureNeedsSaving = true;
                                            mapDataServer.fogPngStale = true;
                                            changed = true;
                                            fog[o] = fog[o + 1] = fog[o + 2] = fog[o + 3] = 255;
                                            MapFog.MarkPixel(x, y);
                                            Tiles.TileStore.OnExplored((x - halfTextureSize) * WebMapConfig.PIXEL_SIZE, (y - halfTextureSize) * WebMapConfig.PIXEL_SIZE);
                                        }
                                    }
                                }
                        }
                    }
                }
            });
            if (changed) mapDataServer.fogRev++;          // once per pass, not per pixel
        }

        public IEnumerator SaveFogTextureLoop()
        {
            while(true)
            {
                yield return new WaitForSeconds(WebMapConfig.SAVE_FOG_TEXTURE_INTERVAL);
                SaveFogTexture();
            }
        }

        public void SaveFogTexture()
        {
            if (mapDataServer.players.Count > 0 && fogTextureNeedsSaving)
            {
                byte[] pngBytes = mapDataServer.GetFogPng();

                if (WebMapConfig.DEBUG) ZLog.Log("Saving Fog");

                try
                {
                    File.WriteAllBytes(Path.Combine(worldDataPath, "fog.png"), pngBytes);
                    fogTextureNeedsSaving = false;
                }
                catch (Exception e)
                {
                    ZLog.LogError("WebMap: FAILED TO WRITE FOG FILE! " + e.Message);
                }
            }
        }

        // Pins change on the game thread (chat) and on HTTP threads (the site): each
        // save writes a snapshot, one save at a time, so the last one written is the newest.
        private static readonly object pinsSaveLock = new object();
        public static void SavePins()
        {
            string mapPinsFile = Path.Combine(worldDataPath, "pins.csv");
            try
            {
                lock (pinsSaveLock)
                {
                    string[] lines;
                    lock (mapDataServer.pins) lines = mapDataServer.pins.ToArray();
                    File.WriteAllLines(mapPinsFile, lines);
                }
            }
            catch (Exception e)
            {
                ZLog.Log("WebMap: FAILED TO WRITE PINS FILE! " + e.Message);
            }
        }

        // The world is there: its data loads. (ForgeMap's own picture of it, map.png, is made from
        // Munin's tiles since 2.0: Tiles/WorldPicture.)
        [HarmonyPatch(typeof(ZoneSystem), nameof(ZoneSystem.Start))]
        private class ZoneSystemPatch
        {
            private static void Postfix()
            {
                WebMap.instance.NewWorld();
                StaticCoroutine.Start(StartWhenGenerated());   // a world just made never runs ZoneSystem.Load
            }
        }

        [HarmonyPatch(typeof(ZoneSystem), nameof(ZoneSystem.Load))]
        private class ZoneSystemLoadPatch
        {
            private static void Postfix() => StartMap("loaded");
        }

        // The map starts once its world's locations are there: a world loaded from its save has them
        // when ZoneSystem.Load is done; a world just made generates them after ZoneSystem.Start, over
        // some seconds, and never runs Load (before 2.0 the map stayed down until a restart). Both
        // ways come here; the first one starts the map.
        private static bool mapStarted;
        private static void StartMap(string how)
        {
            if (mapStarted || ZoneSystem.instance == null) return;
            mapStarted = true;
            ZLog.Log("WebMap: the world is " + how + ": starting the map");
            ZoneSystem.LocationInstance startLocation;
            if (ZoneSystem.instance.FindClosestLocation("StartTemple", Vector3.zero, out startLocation))
            {
                var p = startLocation.m_position;
                WebMapConfig.WORLD_START_POS = p;
                ZLog.Log("WebMap: starting point " + WebMapConfig.WORLD_START_POS.ToString());
            }
            else
            {
                ZLog.LogError("WebMap: failed to find starting point");
            }
            mapDataServer.RefreshConfig();               // the start position is part of /config

            WebMap.instance.Online();

            mapDataServer.ListenAsync();
        }

        // a world just made: its locations come over the first seconds (ZoneSystem.GenerateLocationsTimeSliced)
        private static IEnumerator StartWhenGenerated()
        {
            float since = -1f;
            while (!mapStarted)
            {
                var zs = ZoneSystem.instance;
                if (zs != null && zs.m_locationsGenerated)
                {
                    // and the start temple placed (the map's home), or two minutes without it
                    if (since < 0f) since = Time.realtimeSinceStartup;
                    if (zs.FindClosestLocation("StartTemple", Vector3.zero, out _) || Time.realtimeSinceStartup - since > 120f)
                    {
                        StartMap("new");
                        yield break;
                    }
                }
                yield return new WaitForSeconds(1f);
            }
        }

        [HarmonyPatch(typeof(ZNet), nameof(ZNet.Start))]
        private class ZNetPatchStart
        {
            private static void Postfix(List<ZNetPeer> ___m_peers)
            {
                mapDataServer.players = ___m_peers;
            }
        }

        [HarmonyPatch(typeof(ZNet), nameof(ZNet.Shutdown))]
        private class ZNetPatchShutdown
        {
            private static void Postfix()
            {
                Stats.Save();
                Trails.Save();
                Activity.Save();
                Tiles.TileStore.Stop();
                ServerLog.Stop();
                mapDataServer.Stop();
                WebMap.instance.NotifyOffline();
            }
        }

        [HarmonyPatch(typeof(ZNet), nameof(ZNet.SetServer))]
        private class ZNetPatchSetServer
        {
            private static void Postfix(bool server, bool openServer, bool publicServer, string serverName, string password, World world)
            {
                WebMap.instance.SetServerInfo(openServer, publicServer, serverName, password, world.m_name, world.m_seedName);
            }
        }

        [HarmonyPatch(typeof(ZNet), nameof(ZNet.Disconnect))]
        private class ZNetPatchDisconnect
        {
            private static void Prefix(ref ZNetPeer peer)
            {
                if (!peer.m_server && !string.IsNullOrEmpty(peer.m_playerName))
                {
                    WebMap.instance.NotifyLeave(peer);
                }
            }
        }

        [HarmonyPatch(typeof(ZRoutedRpc), nameof(ZRoutedRpc.AddPeer))]
        private class ZRoutedRpcAddPeerPatch
        {
            private static void Postfix(ZNetPeer peer)
            {
                if (!peer.m_server && !string.IsNullOrEmpty(peer.m_playerName))
                {
                    WebMap.instance.NotifyJoin(peer);
                }
            }
        }

        // Chat in 1.0 is addressed to each recipient, not broadcast, so the server's
        // HandleRoutedRPC never sees it:
        //     if (target == m_id || target == 0) HandleRoutedRPC(data);
        //     if (m_server && target != m_id)    RouteRPC(data);
        // RouteRPC is the branch a player-to-player message takes, and the server runs
        // it while forwarding. Observing there needs no fake server player, so it stays
        // clear of the join path that patch breaks.
        //
        // A shout is sent once per recipient, so the same message arrives N times and
        // has to be de-duplicated. Everybody-targeted RPCs (pings) are skipped, since
        // HandleRoutedRPC already reports those.
        [HarmonyPatch(typeof(ZRoutedRpc), "RouteRPC")]
        private class ZRoutedRpcRoutePatch
        {
            private static readonly Dictionary<string, float> recent = new Dictionary<string, float>();

            private static readonly int SayHash = "Say".GetStableHashCode();
            private static readonly int ChatHash = "ChatMessage".GetStableHashCode();

            private static void Prefix(ref ZRoutedRpc __instance, RoutedRPCData rpcData)
            {
                if (rpcData == null || rpcData.m_targetPeerID == 0L) return;
                // Decide whether this is chat before doing anything else. The server
                // forwards every routed RPC between players through here -- thousands
                // a second with a few people on -- and hashing each one's body to
                // de-duplicate it was a per-RPC tax on the game thread. Only a chat
                // shout needs de-duplicating, since it arrives once per recipient.
                if (!IsChat(rpcData.m_methodHash)) return;
                try
                {
                    if (IsDuplicate(rpcData)) return;
                    RoutedRPCData data = rpcData;
                    ZRoutedRpcPatch.Observe(ref __instance, ref data);
                }
                catch (Exception ex)
                {
                    ZLog.LogWarning("WebMap: failed observing a routed rpc: " + ex);
                }
            }

            internal static bool IsChat(int method) => method == SayHash || method == ChatHash;

            internal static bool IsDuplicate(RoutedRPCData d)
            {
                byte[] body = d.m_parameters != null ? d.m_parameters.GetArray() : null;
                uint h = 2166136261u;
                if (body != null)
                    foreach (byte b in body) { h ^= b; h *= 16777619u; }
                string key = d.m_senderPeerID + ":" + d.m_methodHash + ":" + h;
                float now = Time.realtimeSinceStartup;
                if (recent.TryGetValue(key, out float seen) && now - seen < 2f) return true;
                recent[key] = now;
                if (recent.Count > 256)
                {
                    var stale = new List<string>();
                    foreach (var kv in recent) if (now - kv.Value > 10f) stale.Add(kv.Key);
                    foreach (var k in stale) recent.Remove(k);
                }
                return false;
            }
        }

        [HarmonyPatch(typeof(ZRoutedRpc), nameof(ZRoutedRpc.HandleRoutedRPC))]
        private class ZRoutedRpcPatch
        {
            private static void Postfix(ref ZRoutedRpc __instance, ref RoutedRPCData data)
            {
                // An RPC addressed to everybody runs both branches of RPC_RoutedRPC --
                // this one and the RouteRPC prefix -- so it arrives here twice. Only chat
                // is de-duplicated: every hit's damage number comes this way too.
                if (data != null && ZRoutedRpcRoutePatch.IsChat(data.m_methodHash) && ZRoutedRpcRoutePatch.IsDuplicate(data)) return;
                Observe(ref __instance, ref data);
            }

            internal static void Observe(ref ZRoutedRpc __instance, ref RoutedRPCData data)
            {
                // Since this also runs from the RouteRPC prefix it sees every routed
                // RPC the server forwards, not just the few addressed to it -- so
                // decide whether this is chat before doing any work. The peer lookup
                // below used to run for all of them, and threw and caught a
                // NullReferenceException each time the sender was not a live peer.
                int hash = data?.m_methodHash ?? 0;
                if (hash == 0) return;          // no data: must not match the caches, which start at 0
                if (hash == WorldEvents.SetGlobalKeyHash) { WorldEvents.OnGlobalKey(data); return; }   // a boss down
                bool isSay = hash == sayMethodHash || hash == "Say".GetStableHashCode();
                bool isChat = hash == chatMessageMethodHash || hash == "ChatMessage".GetStableHashCode();
                if (!isSay && !isChat)
                {
                    if (WebMapConfig.DEBUG) ZLog.Log("RoutedRPC: " + hash);
                    return;
                }

                ZNetPeer peer = ZNet.instance.GetPeer(data.m_senderPeerID);
                string steamid = "";
                if (peer != null)
                {
                    try
                    {
                        steamid = peer.m_rpc.GetSocket().GetHostName();
                    }
                    catch
                    {
                        // ignored
                    }
                }

                if (isSay)
                {
                    sayMethodHash = data.m_methodHash;
                    try
                    {
                        // A copy: RouteRPC still has to forward this packet onward,
                        // so the original's read position must not move.
                        ZPackage package = new ZPackage(data.m_parameters.GetArray());
                        var messageType = package.ReadInt();
                        var userInfo = new UserInfo();
                        userInfo.Deserialize(ref package);
                        string message = package.ReadString() ?? "";
                        message = message.Trim();

                        // !pin / !repère, !undoPin / !annulerrepère, !deletePin / !supprrepère
                        ChatCommands.Command cmd = ChatCommands.Parse(message);
                        bool isPinCommand = cmd.kind != ChatCommands.Kind.None;
                        Vector3 pos = Vector3.zero;
                        if (isPinCommand)
                        {
                            // A pin belongs to somebody and sits somewhere. Without an owner
                            // every pin in the list would answer to StartsWith("") and the
                            // overflow trim would delete other players' pins.
                            ZDO zdoData = peer != null ? ZDOMan.instance.GetZDO(peer.m_characterID) : null;
                            if (zdoData == null || string.IsNullOrEmpty(steamid))
                            {
                                ZLog.LogWarning("WebMap: ignoring a pin command from a sender with no "
                                                + (zdoData == null ? "position" : "id"));
                                return;
                            }
                            pos = zdoData.GetPosition();
                        }

                        if (cmd.kind == ChatCommands.Kind.Pin)
                        {
                            long timestamp = new DateTimeOffset(DateTime.UtcNow).ToUnixTimeSeconds();

                            string pinId = $"{timestamp}-{Random.Range(1000, 9999)}";
                            // the site writes pins from HTTP threads: a find and its remove stay together
                            lock (mapDataServer.pins)
                            {
                                mapDataServer.AddPin(steamid, pinId, cmd.type, userInfo.Name, pos, cmd.text);

                                List<string> usersPins = mapDataServer.pins.FindAll(pin => pin.StartsWith(steamid));
                                int numOverflowPins = usersPins.Count - WebMapConfig.MAX_PINS_PER_USER;
                                for (int t = numOverflowPins; t > 0; t--)
                                {
                                    int pinIdx = mapDataServer.pins.FindIndex(pin => pin.StartsWith(steamid));
                                    mapDataServer.RemovePin(pinIdx);
                                }
                            }

                            SavePins();
                        }
                        else if (cmd.kind == ChatCommands.Kind.Undo)
                        {
                            bool took = false;
                            lock (mapDataServer.pins)
                            {
                                int pinIdx = mapDataServer.pins.FindLastIndex(pin => pin.StartsWith(steamid));
                                if (pinIdx > -1) { mapDataServer.RemovePin(pinIdx); took = true; }
                            }
                            if (took) SavePins();
                        }
                        else if (cmd.kind == ChatCommands.Kind.Delete)
                        {
                            string pinText = cmd.text;
                            bool took = false;
                            lock (mapDataServer.pins)
                            {
                                int pinIdx = mapDataServer.pins.FindLastIndex(pin =>
                                {
                                    string[] pinParts = pin.Split(',');
                                    return pinParts[0] == steamid && pinParts[pinParts.Length - 1] == pinText;
                                });
                                if (pinIdx > -1) { mapDataServer.RemovePin(pinIdx); took = true; }
                            }
                            if (took) SavePins();
                        }
                        else
                        {
                            if (messageType != (int)Talker.Type.Whisper)
                            {
                                mapDataServer.AddMessage(data.m_senderPeerID, messageType, userInfo.Name, message);
                                Stats.Chat(userInfo.Name);
                                Discord.PostChat(userInfo.Name, message);
                            }
                            // one console line per chat message and per ping is spam on a
                            // busy server; the web feed is where these are meant to be read
                            if (WebMapConfig.DEBUG)
                                ZLog.Log($"WebMap: (say) {messageType} | {userInfo.Name} | {message}");
                        }
                    }
                    catch (Exception ex)
                    {
                        ZLog.LogWarning("WebMap: failed handling a chat message: " + ex);
                    }
                }
                else
                {
                    chatMessageMethodHash = data.m_methodHash;
                    try
                    {
                        ZPackage package = new ZPackage(data.m_parameters.GetArray());
                        Vector3 pos = package.ReadVector3();
                        var messageType = package.ReadInt();
                        var userInfo = new UserInfo();
                        userInfo.Deserialize(ref package);

                        if (messageType == (int)Talker.Type.Ping)
                        {
                            mapDataServer.BroadcastPing(data.m_senderPeerID, userInfo.Name, pos);
                            if (WebMapConfig.DEBUG)
                                ZLog.Log($"WebMap: (ping) {pos} | {messageType} | {userInfo.Name}");
                        }
                        else
                        {
                            var message = package.ReadString() ?? "";
                            message = message.Trim();

                            mapDataServer.AddMessage(data.m_senderPeerID, messageType, userInfo.Name, message);

                            Stats.Chat(userInfo.Name);
                            Discord.PostChat(userInfo.Name, message);
                            if (WebMapConfig.DEBUG)
                                ZLog.Log($"WebMap: (chat) {pos} | {messageType} | {userInfo.Name} | {message}");
                        }
                    }
                    catch (Exception ex)
                    {
                        if (WebMapConfig.DEBUG) ZLog.LogError(ex.ToString());
                    }
                }
            }
        }
    }

    public class StaticCoroutine {
        private static StaticCoroutineRunner runner;

        public static Coroutine Start(IEnumerator coroutine) {
            EnsureRunner();
            return runner.StartCoroutine(coroutine);
        }

        private static void EnsureRunner() {
            if (runner == null) {
                runner = new GameObject("[Static Coroutine Runner]").AddComponent<StaticCoroutineRunner>();
                UnityEngine.Object.DontDestroyOnLoad(runner.gameObject);
            }
        }

        private class StaticCoroutineRunner : MonoBehaviour { }
    }
}
