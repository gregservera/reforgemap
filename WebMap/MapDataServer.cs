using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Reflection;
using System.Text;
using UnityEngine;
using WebSocketSharp;
using WebSocketSharp.Net;
using WebSocketSharp.Server;
using static WebMap.WebMapConfig;

namespace WebMap
{
    [Serializable]
    public struct MapMessage
    {
        public long id;
        public int type;
        public string name;
        public string message;
        public string ts;
        // 1 for the server's own joined/left/died lines, 0 for anything a person
        // said -- chat and announcements. The feed is read as a chat monitor, and
        // the events outnumber chat by thirty to one.
        public int ev;

        public MapMessage(long id, int type, string name, string message, bool ev = false)
        {
            this.id = id;
            this.type = type;
            this.name = name;
            this.message = message;
            this.ev = ev ? 1 : 0;
            this.ts = DateTime.UtcNow.ToString("o", System.Globalization.CultureInfo.InvariantCulture);
        }

        public string ToJson()
        {
            return JsonUtility.ToJson(this);
        }
    }

    public class WebSocketHandler : WebSocketBehavior
    {
        protected override void OnOpen()
        {
            string endpoint = Context.Headers.Get("X-Forwarded-For");
            if (endpoint.IsNullOrEmpty())
            {
                endpoint = Context.UserEndPoint.ToString();
            }
            ZLog.Log("WebMap: new visitor connected from " + endpoint);
            base.OnOpen();
        }

        protected override void OnMessage(MessageEventArgs e)
        {
            if (e.Data.ToString() == "players")
            {
                Send(MapDataServer.getInstance().PlayersWs);
            }
            base.OnMessage(e);
        }
    }

    public class MapDataServer
    {
        // Every kind of file under web/: anything else answers 404, so a new asset type needs a row here.
        internal static readonly Dictionary<string, string> contentTypes = new Dictionary<string, string> {
            {"html", "text/html"},
            {"js", "text/javascript"},
            {"css", "text/css"},
            {"png", "image/png"},
            {"jpg", "image/jpeg"},
            {"webp", "image/webp"},
            {"woff2", "font/woff2"},
            {"txt", "text/plain"},
            {"svg", "image/svg+xml"}      // Munin's page: its icon
        };

        private System.Threading.Timer broadcastTimer;
        // Written from HTTP threads, and a browser opens several connections at once
        // on the first page load: a plain Dictionary can corrupt under that.
        private readonly System.Collections.Concurrent.ConcurrentDictionary<string, byte[]> fileCache;
        private readonly System.Collections.Concurrent.ConcurrentDictionary<string, DateTime> fileStamp;   // when each cached file was read
        // The fog as bytes, laid out like a texture. A Texture2D is only the PNG
        // decoder at load; every read and write after that is on this array, so the
        // encode can run on any thread. A pixel only ever turns white, so an encode
        // that overlaps a write is at worst one pixel behind.
        public byte[] fogRgba;
        public void SetFog(Texture2D tex, bool fresh)
        {
            int n = WebMapConfig.TEXTURE_SIZE * WebMapConfig.TEXTURE_SIZE;
            var b = new byte[n * 4];
            if (fresh)
            {
                for (int i = 3; i < b.Length; i += 4) b[i] = 255;      // opaque black: nothing explored
            }
            else
            {
                var px = tex.GetPixels32();
                for (int i = 0; i < px.Length && i < n; i++) { int o = i * 4; b[o] = px[i].r; b[o + 1] = px[i].g; b[o + 2] = px[i].b; b[o + 3] = px[i].a; }
            }
            fogRgba = b;
            fogPngStale = true;
            MapFog.RebuildChunks(b);
        }
        private readonly HttpServer httpServer;

        public byte[] mapImageData;
        private byte[] mapJpgCache;          // built once; the world render never changes

        // The fog changes a few pixels every couple of seconds and is asked for far
        // more often than that. Encode when it has changed, serve the bytes otherwise.
        // EncodeArrayToPNG is thread-safe, so this may run on the HTTP thread.
        public volatile bool fogPngStale = true;
        public volatile int fogRev = 1;          // bumped once per pass that revealed anything
        private byte[] fogPngCache;
        private readonly object fogPngLock = new object();
        public byte[] GetFogPng()
        {
            lock (fogPngLock)
            {
                if (fogPngStale || fogPngCache == null)
                {
                    if (fogRgba == null) return fogPngCache ?? new byte[0];
                    int size = WebMapConfig.TEXTURE_SIZE;
                    fogPngCache = ImageConv.EncodeRgbaToPNG(fogRgba, size, size);
                    fogPngStale = false;
                }
                return fogPngCache;
            }
        }

        public void BuildMapJpg()
        {
            if (mapJpgCache != null) return;
            if (mapImageData == null || mapImageData.Length == 0) return;
            try
            {
                int size = WebMapConfig.RENDER_SIZE;      // LoadImage resizes anyway
                var tex = new Texture2D(size, size, TextureFormat.RGBA32, false);
                if (!ImageConv.LoadImage(tex, mapImageData)) return;
                mapJpgCache = ImageConv.EncodeToJPG(tex, 85);
                UnityEngine.Object.Destroy(tex);
                ZLog.Log($"WebMap: world render as jpeg: {mapJpgCache.Length} bytes (png was {mapImageData.Length})");
            }
            catch (Exception ex)
            {
                ZLog.LogWarning("WebMap: jpeg encode failed: " + ex);
            }
        }
        public List<string> pins = new List<string>();
        public List<MapMessage> sentMessages = new List<MapMessage>();
        public List<MapMessage> newMessages = new List<MapMessage>();
        // Chat arrives on the game thread, is drained by a timer on a pool thread,
        // and is read by HTTP on a third -- so the lists are never touched without
        // this, and /messages serves a snapshot the timer builds rather than walking
        // a list another thread is editing. Latent until 2.9.0: before chat could be
        // observed at all, these lists were almost always empty.
        private readonly object messageLock = new object();
        private volatile string messagesJson = "[]";
        public List<ZNetPeer> players = new List<ZNetPeer>();
        public string lastPlayerResponse = "";
        // Player state comes from ZDOMan and from ZNet's own live m_peers list, and
        // neither may be read off the game thread: the broadcast timer runs on a pool
        // thread and HTTP on others again, so both would be walking a list the game is
        // editing. RefreshPlayerSnapshot runs on the game thread and everyone else
        // only ever reads these strings.
        private volatile string playersWs = "players";
        private volatile string playersJson = "{\"count\":0,\"players\":[]}";
        // the same players for Munin's map over the websocket, every tick: no look (a few KB a player,
        // the 3D view's, fetched with /state), but an id and the game's pvp flag (BuildPlayersJson)
        private volatile string playersLive = "[]";
        public string PlayersWs => playersWs;
        private bool forceReload = false;
        // /config carries the world name, which lives on ZNet: main-thread state.
        // The main thread builds this when the world loads; HTTP only serves it.
        private volatile string configJson = "{}";
        public void RefreshConfig() => configJson = MakeClientConfigJson();
        // Reads that the world sweep exists to serve. Anything a monitor probes
        // (/config, /players, /map, /pins, /messages) must not keep it running.
        private static readonly HashSet<string> sweepReads = new HashSet<string> {
            "/structures", "/forest", "/fog", "/vehicles", "/portals", "/graves", "/pieces", "/trails",
            "/forest/stats", "/structures/stats", "/state", "/objects", "/height", "/prefabs", "/locations"
        };
        // The game's clock for the 3D view's sky, built on the game thread with the players:
        // the day and the fraction of it EnvMan lights the world by (0.25 sunrise, 0.5 noon).
        private volatile string timeJson = "null";
        private volatile Tuple<int, byte[]> prefabsBytes;       // /prefabs as sent, per library revision
        private readonly string publicRoot;
        private readonly WebSocketServiceHost webSocketHandler;
        private static MapDataServer __instance;

        // Nothing here listens or ticks: ListenAsync does both, so a test can build one.
        public MapDataServer() : this(null) { }

        // the tests': bound to loopback alone
        internal MapDataServer(System.Net.IPAddress address)
        {
            __instance = this;

            httpServer = address == null ? new HttpServer(SERVER_PORT) : new HttpServer(address, SERVER_PORT);
            httpServer.AddWebSocketService<WebSocketHandler>("/");
            httpServer.KeepClean = true;

            webSocketHandler = httpServer.WebSocketServices["/"];

            publicRoot = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) ?? string.Empty, "web");

            fileCache = new System.Collections.Concurrent.ConcurrentDictionary<string, byte[]>();
            fileStamp = new System.Collections.Concurrent.ConcurrentDictionary<string, DateTime>();

            httpServer.OnGet += (sender, e) =>
            {
                if (ProcessSpecialRoutes(e)) return;

                ServeStaticFiles(e);
            };
            // /announce is a POST; without this websocket-sharp answers 501
            httpServer.OnPost += (sender, e) =>
            {
                if (ProcessSpecialRoutes(e)) return;

                e.Response.StatusCode = 404;
                e.Response.Close();
            };
        }

        // Called only from RefreshPlayerSnapshot, i.e. only on the game thread.
        private string BuildPlayerResponse()
        {
            string dataString = "players\n";

            players.ForEach(player =>
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
                    int maxHealth = (int)Math.Ceiling(zdoData.GetFloat(ZDOVars.s_maxHealth, 25));
                    int health = (int)Math.Ceiling(zdoData.GetFloat(ZDOVars.s_health, maxHealth));
                    int dead = zdoData.GetBool(ZDOVars.s_dead) ? 1 : 0;
                    int pvp = zdoData.GetBool(ZDOVars.s_pvp) ? 1 : 0;
                    int inbed = zdoData.GetBool(ZDOVars.s_inBed) ? 1 : 0;

                    maxHealth = Math.Max(maxHealth, health);

                    dataString += $"{player.m_uid}\n{player.m_playerName}\n{health}\n{maxHealth}\n";
                    if (!player.m_publicRefPos)
                        dataString += "hidden\n";
                    if (player.m_publicRefPos || WebMapConfig.ALWAYS_VISIBLE || WebMapConfig.ALWAYS_MAP)
                        dataString += FormattableString.Invariant($"{pos.x:0.##},{pos.z:0.##}\n");
                    dataString += $"{dead}{pvp}{inbed}\n\n";
                }

            });
            return dataString.Trim();
        }

        // Same data the websocket "players" frame carries, as JSON, so plain HTTP
        // clients don't have to speak websocket. Position is omitted for players
        // who chose to be hidden (unless ALWAYS_VISIBLE), matching the map's own
        // behaviour -- a hidden player must not leak coordinates over HTTP either.
        private string BuildPlayersJson(float now)
        {
            var entries = new List<string>();
            var live = new List<string>();
            players.ForEach(player =>
            {
                ZDO zdoData = null;
                try { zdoData = ZDOMan.instance.GetZDO(player.m_characterID); } catch { }
                if (zdoData == null) return;

                Vector3 pos = zdoData.GetPosition();
                int maxHealth = (int)Math.Ceiling(zdoData.GetFloat(ZDOVars.s_maxHealth, 25));
                int health = (int)Math.Ceiling(zdoData.GetFloat(ZDOVars.s_health, maxHealth));
                maxHealth = Math.Max(maxHealth, health);
                bool hidden = !player.m_publicRefPos;
                bool showPos = player.m_publicRefPos || WebMapConfig.ALWAYS_VISIBLE;
                // how they look is no spoiler of where they are: kept for their page either way
                int yaw = (int)Math.Round(zdoData.GetRotation().eulerAngles.y);
                string look = null;
                try { look = Models.RigExporter.LookJson(zdoData); } catch (Exception e) { WarnOnce(ref lookWarned, "a player's look failed, they stand as a plain figure", e); }
                Stats.Looked(player.m_playerName, look, yaw);

                var sb = new StringBuilder();
                sb.Append("{\"name\":\"").Append(JsonEscape(player.m_playerName)).Append("\"");
                int mark = sb.Length;
                sb.Append(",\"health\":").Append(health);
                sb.Append(",\"maxHealth\":").Append(maxHealth);
                sb.Append(",\"dead\":").Append(zdoData.GetBool(ZDOVars.s_dead) ? "true" : "false");
                sb.Append(",\"inBed\":").Append(zdoData.GetBool(ZDOVars.s_inBed) ? "true" : "false");
                sb.Append(",\"hidden\":").Append(hidden ? "true" : "false");
                // the round trip to the server, ms, averaged over the last minute; left out while unknown
                int ping = Ping.Of(player, now);
                if (ping >= 0) sb.Append(",\"ping\":").Append(ping);
                if (showPos)
                {
                    sb.Append(FormattableString.Invariant($",\"x\":{pos.x:0.##},\"z\":{pos.z:0.##}"));
                    // the 3D view draws them as the game does: facing their way, in what they wear
                    sb.Append(",\"yaw\":").Append(yaw);
                    // their biome and the weather they have there (Weather: the game's own draw for the spot)
                    try
                    {
                        if (WorldGenerator.instance != null)
                            sb.Append(",\"biome\":\"").Append(JsonEscape(Tiles.Palette.BiomeName((int)WorldGenerator.instance.GetBiome(pos)))).Append('"');
                        if (Weather.At(pos, out var w))
                            sb.Append(",\"weather\":\"").Append(JsonEscape(w.name)).Append('"')
                              .Append(FormattableString.Invariant($",\"windDeg\":{w.windDeg:0},\"wind\":{w.wind:0.##}"));
                    }
                    catch { }
                }
                string common = sb.ToString(mark, sb.Length - mark);
                live.Add("{\"id\":" + player.m_uid.ToString(CultureInfo.InvariantCulture) + ",\"name\":\"" + JsonEscape(player.m_playerName) + "\""
                         + common + ",\"pvp\":" + (zdoData.GetBool(ZDOVars.s_pvp) ? "true" : "false") + "}");
                if (showPos && look != null) sb.Append(",\"look\":").Append(look);
                sb.Append("}");
                entries.Add(sb.ToString());
            });
            playersLive = "[" + string.Join(",", live) + "]";
            return "{\"count\":" + entries.Count + ",\"players\":[" + string.Join(",", entries) + "]}";
        }

        private static string JsonEscape(string s)
        {
            if (string.IsNullOrEmpty(s)) return "";
            return s.Replace("\\", "\\\\").Replace("\"", "\\\"").Replace("\n", " ").Replace("\r", " ").Replace("\t", " ");
        }

        public static MapDataServer getInstance()
        {
            return __instance;
        }
        public void Stop()
        {
            broadcastTimer?.Dispose();
            httpServer.Stop();
        }

        private void ServeStaticFiles(HttpRequestEventArgs e)
        {
            HttpListenerRequest req = e.Request;
            HttpListenerResponse res = e.Response;

            string rawRequestPath = req.RawUrl.Split('?')[0];   // ?v= is for caches, not for us
            if (rawRequestPath == "/") rawRequestPath = "/index.html";

            // A path under web/, subfolders included (the vendored three.js keeps its
            // layout, which its own imports depend on). Plain names and forward slashes
            // only: a backslash is a separator on Windows and a dot-segment climbs out,
            // so either is refused, and the resolved path must still be under web/.
            string requestedFile = rawRequestPath.TrimStart('/');
            string filePath = null;
            if (requestedFile.Length > 0 && requestedFile.IndexOf('\\') < 0 && requestedFile.IndexOf(':') < 0
                && Array.TrueForAll(requestedFile.Split('/'), s => s.Length > 0 && s[0] != '.'))
            {
                try
                {
                    string rootFull = Path.GetFullPath(publicRoot) + Path.DirectorySeparatorChar;
                    string full = Path.GetFullPath(Path.Combine(publicRoot, requestedFile.Replace('/', Path.DirectorySeparatorChar)));
                    if (full.StartsWith(rootFull, StringComparison.Ordinal)) filePath = full;
                }
                catch { }
            }
            string[] fileParts = requestedFile.Split('.');
            string fileExt = fileParts[fileParts.Length - 1];

            if (filePath != null && contentTypes.ContainsKey(fileExt))
            {
                byte[] requestedFileBytes = new byte[0];
                // A deploy writes a new file under the same name, so the cache holds
                // bytes only for as long as the file still carries the timestamp they
                // were read at: one stat per request, and a new viewer shows at once.
                DateTime stamp = DateTime.MinValue;
                try { stamp = File.GetLastWriteTimeUtc(filePath); } catch { }
                if (!fileCache.TryGetValue(requestedFile, out requestedFileBytes)
                    || !fileStamp.TryGetValue(requestedFile, out var readAt) || readAt != stamp)
                {
                    requestedFileBytes = new byte[0];
                    try
                    {
                        requestedFileBytes = File.ReadAllBytes(filePath);
                        if (CACHE_SERVER_FILES && Cacheable(requestedFile, requestedFileBytes.Length)) { fileCache[requestedFile] = requestedFileBytes; fileStamp[requestedFile] = stamp; }
                    }
                    catch (Exception ex)
                    {
                        ZLog.LogError("WebMap: FAILED TO READ FILE! " + ex.Message);
                    }
                }

                if (requestedFileBytes.Length > 0)
                {
                    // a page must pick up a new build on the next visit; its assets can wait a bit
                    res.Headers.Add(HttpResponseHeader.CacheControl, fileExt == "html" ? "no-cache" : "public, max-age=300");
                    // text goes gzipped where it can: three.js is 2 MB as written, a quarter of that zipped
                    byte[] gz = null;
                    if ((fileExt == "html" || fileExt == "js" || fileExt == "css") && TakesGzip(req, requestedFileBytes))
                    {
                        if (staticGz.TryGetValue(requestedFile, out var kept) && kept.Item1 == stamp) gz = kept.Item2;
                        else staticGz[requestedFile] = Tuple.Create(stamp, gz = Gzip(requestedFileBytes));
                    }
                    if (fileExt == "html")
                    {
                        // the link preview's tags, for this server and the address it was reached at
                        byte[] page = requestedFileBytes;
                        try { page = Encoding.UTF8.GetBytes(Preview.Page(req, Encoding.UTF8.GetString(requestedFileBytes))); } catch { }
                        gz = page != requestedFileBytes && TakesGzip(req, page) ? Gzip(page) : gz;
                        requestedFileBytes = page;
                    }
                    Send(res, requestedFileBytes, gz, contentTypes[fileExt]);
                }
                else
                {
                    res.StatusCode = 404;
                    res.Close();
                }
            }
            else
            {
                res.StatusCode = 404;
                res.Close();
            }
        }

        private bool ProcessSpecialRoutes(HttpRequestEventArgs e)
        {
            HttpListenerRequest req = e.Request;
            HttpListenerResponse res = e.Response;
            string rawRequestPath = req.RawUrl.Split('?')[0];
            byte[] textBytes;

            if (sweepReads.Contains(rawRequestPath)) StructureMap.LastRead = Environment.TickCount;

            if (rawRequestPath.StartsWith("/models/", StringComparison.Ordinal) && req.HttpMethod == "GET")
            {
                ServeModel(req, res, rawRequestPath.Substring(8));
                return true;
            }
            // Munin's map: the tile pyramid and the trees and rocks over walked ground. Reading
            // tiles does not arm the sweep, as /map does not.
            if (rawRequestPath.StartsWith("/tiles/", StringComparison.Ordinal) && req.HttpMethod == "GET")
            {
                ServeTile(req, res, rawRequestPath);
                return true;
            }
            if (rawRequestPath.StartsWith("/data/", StringComparison.Ordinal) && req.HttpMethod == "GET")
            {
                StructureMap.LastRead = Environment.TickCount;
                ServeData(req, res, rawRequestPath.Substring("/data/".Length));
                return true;
            }

            if ((rawRequestPath.StartsWith("/icons/game/", StringComparison.Ordinal) || rawRequestPath.StartsWith("/icons/item/", StringComparison.Ordinal)) && req.HttpMethod == "GET")
            {
                // the game's own map icons (Tiles/MapIcons) and item icons (Tiles/ItemIcons), cut from its files
                bool item = rawRequestPath[7] == 'i';
                string dir = item ? Tiles.ItemIcons.Dir : Tiles.MapIcons.Dir, name = rawRequestPath.Substring(12);
                if (dir != null && name.EndsWith(".png", StringComparison.Ordinal) && name.IndexOfAny(new[] { '/', '\\' }) < 0 && !name.Contains(".."))
                {
                    if (item) name = Tiles.ItemIcons.Safe(name.Substring(0, name.Length - 4)) + ".png";
                    string full = Path.Combine(dir, name);
                    byte[] data = null;
                    try { if (name.Length > 4 && File.Exists(full)) data = File.ReadAllBytes(full); } catch { }
                    if (data != null)
                    {
                        res.Headers.Add(HttpResponseHeader.CacheControl, "public, max-age=86400");
                        SendBytes(req, res, data, "image/png");
                        return true;
                    }
                }
                res.StatusCode = 404; res.Close();
                return true;
            }
            if (rawRequestPath.StartsWith("/preview-image.", StringComparison.Ordinal) && req.HttpMethod == "GET")
            {
                // the link preview's picture (preview_image), at the extension it was announced with
                byte[] img = Preview.Image(out string ictype);
                if (img == null || Path.GetExtension(rawRequestPath).ToLowerInvariant() != Path.GetExtension(Preview.FilePath() ?? "").ToLowerInvariant())
                { res.StatusCode = 404; res.Close(); return true; }
                res.Headers.Add(HttpResponseHeader.CacheControl, "public, max-age=3600");
                SendBytes(req, res, img, ictype);
                return true;
            }

            switch (rawRequestPath)
            {
                case "/prefabs":
                    // the model library's index: which prefabs have a model, their bounds, their canopy
                    {
                        res.Headers.Add(HttpResponseHeader.CacheControl, "no-cache");
                        var pb = prefabsBytes;
                        if (pb == null || pb.Item1 != Models.ModelStore.Rev)
                            prefabsBytes = pb = Tuple.Create(Models.ModelStore.Rev, Encoding.UTF8.GetBytes(Models.ModelStore.PrefabsJson));
                        SendBytes(req, res, pb.Item2, "application/json");
                        return true;
                    }
                case "/objects":
                case "/height":
                    // one 256 m chunk of the 3D view, never for ground nobody has walked
                    {
                        res.Headers.Add(HttpResponseHeader.CacheControl, "no-cache");
                        if (!int.TryParse(req.QueryString["cx"], NumberStyles.Integer, CultureInfo.InvariantCulture, out int cx)
                            || !int.TryParse(req.QueryString["cz"], NumberStyles.Integer, CultureInfo.InvariantCulture, out int cz))
                        { Answer(res, 400, "{\"error\":\"cx and cz are chunk numbers: floor(metres / 256)\"}"); return true; }
                        if (!MapFog.ChunkExplored(cx, cz)) { Answer(res, 404, "{\"error\":\"unexplored\"}"); return true; }
                        int rev;
                        byte[] bytes;
                        if (rawRequestPath == "/objects") bytes = WorldObjects.ChunkBytes(cx, cz, out rev);
                        else
                        {
                            // step: metres between samples, for the view's far rings; 1 unless asked
                            string st = req.QueryString["step"];
                            int step = 1;
                            if (st != null && (!int.TryParse(st, NumberStyles.Integer, CultureInfo.InvariantCulture, out step) || !Heights.ValidStep(step)))
                            { Answer(res, 400, "{\"error\":\"step is 1, 2, 4, 8 or 16\"}"); return true; }
                            try { bytes = Heights.Chunk(cx, cz, step, false, out rev); }
                            catch (Exception ex) { ZLog.LogWarning("WebMap: heights failed: " + ex.Message); bytes = null; rev = 0; }
                        }
                        if (bytes == null) { Answer(res, 503, "{\"error\":\"not ready\"}"); return true; }
                        res.Headers.Add("X-Rev", rev.ToString(CultureInfo.InvariantCulture));
                        SendBytes(req, res, bytes, "application/octet-stream");
                        return true;
                    }
                case "/api/serverlog":
                    // the game's console lines after number `after` (-1: the latest `limit`): an admin's,
                    // a signed-in admin or the holder of the announce token
                    {
                        bool tokenHolder = Auth.Same(Announce.Token, req.Headers["X-Announce-Token"] ?? "");
                        if (!tokenHolder && (!Caller(req, out _, out bool logAdmin) || !logAdmin)) { Answer(res, 403, "{\"error\":\"forbidden\"}"); return true; }
                        long after = long.TryParse(req.QueryString["after"] ?? "-1", NumberStyles.Integer, CultureInfo.InvariantCulture, out long a) ? a : -1;
                        int limit = int.TryParse(req.QueryString["limit"] ?? "1000", NumberStyles.Integer, CultureInfo.InvariantCulture, out int l) ? Math.Max(1, Math.Min(4000, l)) : 1000;
                        res.Headers.Add(HttpResponseHeader.CacheControl, "no-store");
                        Answer(res, 200, ServerLog.Json(after, limit));
                        return true;
                    }
                case "/api/bases/reset":
                    // every base back to its own name and shown again: an admin's
                    {
                        if (req.HttpMethod != "POST") { Answer(res, 405, "{\"error\":\"POST\"}"); return true; }
                        if (!Caller(req, out _, out bool admin) || !admin) { Answer(res, 403, "{\"error\":\"forbidden\"}"); return true; }
                        Answer(res, 200, "{\"cleared\":" + Tiles.Markers.ClearOverrides() + "}");
                        return true;
                    }
                case "/api/status":
                    // how far the map's drawing has got
                    res.Headers.Add(HttpResponseHeader.CacheControl, "no-cache");
                    Answer(res, 200, "{\"tiles\":" + Tiles.TileStore.StatusJson() + "}");
                    return true;
                case "/api/rerender":
                    // draw the tiles again from a zoom up (after a look change): an admin's
                    {
                        if (req.HttpMethod != "POST") { Answer(res, 405, "{\"error\":\"POST\"}"); return true; }
                        if (!Caller(req, out _, out bool admin) || !admin) { Answer(res, 403, "{\"error\":\"forbidden\"}"); return true; }
                        if (!int.TryParse(req.QueryString["zoom"] ?? "0", NumberStyles.Integer, CultureInfo.InvariantCulture, out int fromZoom)
                            || fromZoom < 0 || fromZoom > Tiles.TileMath.MAX_ZOOM)
                        { Answer(res, 400, "{\"error\":\"zoom is 0 to " + Tiles.TileMath.MAX_ZOOM + "\"}"); return true; }
                        Answer(res, 202, "{\"queued\":" + Tiles.TileStore.Rerender(fromZoom) + "}");
                        return true;
                    }
                case "/config":
                    res.Headers.Add(HttpResponseHeader.CacheControl, "no-cache");
                    res.ContentType = "application/json";
                    res.StatusCode = 200;
                    textBytes = Encoding.UTF8.GetBytes(configJson);
                    res.ContentLength64 = textBytes.Length;
                    res.Close(textBytes, true);
                    return true;
                case "/map.jpg":
                    // The world render is opaque and several MB as a PNG, which is a
                    // long transatlantic download on a cold edge. As a JPEG it is
                    // roughly a seventh of that, and the loss is invisible on terrain.
                    {
                        byte[] jpg = mapJpgCache;
                        if (jpg == null || jpg.Length == 0)
                        {
                            res.StatusCode = 503;
                            res.Close();
                            return true;
                        }
                        res.Headers.Add(HttpResponseHeader.CacheControl, "public, max-age=604800, immutable");
                        res.ContentType = "image/jpeg";
                        res.StatusCode = 200;
                        res.ContentLength64 = jpg.Length;
                        res.Close(jpg, true);
                        return true;
                    }
                case "/map":
                    if (mapImageData == null || mapImageData.Length == 0)
                    {
                        res.StatusCode = 503;          // still rendering; never cached
                        res.Close();
                        return true;
                    }
                    // Doing things this way to make the full map harder to accidentally see.
                    res.Headers.Add(HttpResponseHeader.CacheControl, "public, max-age=604800, immutable");
                    res.ContentType = "application/octet-stream";
                    res.StatusCode = 200;
                    res.ContentLength64 = mapImageData.Length;
                    res.Close(mapImageData, true);
                    return true;
                case "/fog":
                    res.Headers.Add(HttpResponseHeader.CacheControl, "no-cache");
                    res.ContentType = "image/png";
                    res.StatusCode = 200;
                    byte[] fogBytes = GetFogPng();
                    if (fogBytes.Length == 0) { res.StatusCode = 503; res.Close(); return true; }   // not rendered yet: never a cacheable empty 200
                    res.ContentLength64 = fogBytes.Length;
                    res.Close(fogBytes, true);
                    return true;
                case "/chart":
                    // one image per world, never changing: let the edge keep it
                    res.Headers.Add(HttpResponseHeader.CacheControl, "public, max-age=3600");
                    res.ContentType = "image/png";
                    res.StatusCode = 200;
                    byte[] chartBytes = Chart.GetPng();
                    if (chartBytes.Length == 0) { res.StatusCode = 503; res.Close(); return true; }   // not rendered yet: never a cacheable empty 200
                    res.ContentLength64 = chartBytes.Length;
                    res.Close(chartBytes, true);
                    return true;
                case "/messages":
                    res.Headers.Add(HttpResponseHeader.CacheControl, "no-cache");
                    res.ContentType = "application/json";
                    res.StatusCode = 200;
                    textBytes = Encoding.UTF8.GetBytes(messagesJson);
                    res.ContentLength64 = textBytes.Length;
                    res.Close(textBytes, true);
                    return true;
                case "/players":
                    res.Headers.Add(HttpResponseHeader.CacheControl, "no-cache");
                    res.ContentType = "application/json";
                    res.StatusCode = 200;
                    textBytes = Encoding.UTF8.GetBytes(playersJson);
                    res.ContentLength64 = textBytes.Length;
                    res.Close(textBytes, true);
                    return true;
                case "/structures":
                    res.Headers.Add(HttpResponseHeader.CacheControl, "no-cache");
                    res.ContentType = "image/png";
                    res.StatusCode = 200;
                    byte[] structureBytes = StructureMap.GetPng();
                    if (structureBytes.Length == 0) { res.StatusCode = 503; res.Close(); return true; }   // not rendered yet: never a cacheable empty 200
                    res.ContentLength64 = structureBytes.Length;
                    res.Close(structureBytes, true);
                    return true;
                case "/forest":
                    res.Headers.Add(HttpResponseHeader.CacheControl, "no-cache");
                    res.ContentType = "image/png";
                    res.StatusCode = 200;
                    byte[] forestBytes = ForestMap.GetPng();
                    if (forestBytes.Length == 0) { res.StatusCode = 503; res.Close(); return true; }   // not rendered yet: never a cacheable empty 200
                    res.ContentLength64 = forestBytes.Length;
                    res.Close(forestBytes, true);
                    return true;
                case "/trails":
                    res.Headers.Add(HttpResponseHeader.CacheControl, "no-cache");
                    res.ContentType = "image/png";
                    res.StatusCode = 200;
                    byte[] trailBytes = Trails.GetPng();
                    if (trailBytes.Length == 0) { res.StatusCode = 503; res.Close(); return true; }   // nothing walked yet, or not rendered
                    res.ContentLength64 = trailBytes.Length;
                    res.Close(trailBytes, true);
                    return true;
                case "/forest/stats":
                    res.Headers.Add(HttpResponseHeader.CacheControl, "no-cache");
                    res.ContentType = "application/json";
                    res.StatusCode = 200;
                    textBytes = Encoding.UTF8.GetBytes(ForestMap.GetStats());
                    res.ContentLength64 = textBytes.Length;
                    res.Close(textBytes, true);
                    return true;
                case "/vehicles":
                    res.Headers.Add(HttpResponseHeader.CacheControl, "no-cache");
                    res.ContentType = "application/json";
                    res.StatusCode = 200;
                    textBytes = Encoding.UTF8.GetBytes(Vehicles.GetJson());
                    res.ContentLength64 = textBytes.Length;
                    res.Close(textBytes, true);
                    return true;
                case "/portals":
                    res.Headers.Add(HttpResponseHeader.CacheControl, "no-cache");
                    res.ContentType = "application/json";
                    res.StatusCode = 200;
                    textBytes = Encoding.UTF8.GetBytes(Portals.GetJson());
                    res.ContentLength64 = textBytes.Length;
                    res.Close(textBytes, true);
                    return true;
                case "/graves":
                    res.Headers.Add(HttpResponseHeader.CacheControl, "no-cache");
                    res.ContentType = "application/json";
                    res.StatusCode = 200;
                    textBytes = Encoding.UTF8.GetBytes(Graves.GetJson());
                    res.ContentLength64 = textBytes.Length;
                    res.Close(textBytes, true);
                    return true;
                case "/locations":
                    // the world's locations in walked ground, for the tour
                    Answer(res, 200, Locations.GetJson());
                    return true;
                case "/pieces":
                    res.Headers.Add(HttpResponseHeader.CacheControl, "no-cache");
                    res.ContentType = "application/json";
                    res.StatusCode = 200;
                    textBytes = Encoding.UTF8.GetBytes(Pieces.GetJson());
                    res.ContentLength64 = textBytes.Length;
                    res.Close(textBytes, true);
                    return true;
                case "/state":
                    // One document per tick for a viewer: every small block the page
                    // polls, and a revision per large layer so it fetches a layer only
                    // when the picture changed. Each block is a string another thread
                    // already built; this is concatenation. The tallies are not among
                    // them: no page reads them here, and /stats/players has them.
                    {
                        string pinsJson = PinsJson();
                        string state = "{\"now\":" + DateTimeOffset.UtcNow.ToUnixTimeSeconds()
                            + ",\"rev\":{\"fog\":" + fogRev + ",\"pieces\":" + Pieces.Rev + ",\"forest\":" + ForestMap.Rev
                            + ",\"structures\":" + StructureMap.Rev + ",\"chart\":" + Chart.Rev + ",\"trails\":" + Trails.Rev
                            + ",\"features\":" + FeaturesRev() + ",\"objects\":" + WorldObjects.Rev + ",\"height\":" + TerrainPatches.Rev
                            + ",\"models\":" + Models.ModelStore.Rev + "}"
                            + ",\"time\":" + timeJson
                            + ",\"players\":" + playersJson + ",\"messages\":" + messagesJson + ",\"pins\":" + pinsJson
                            + ",\"vehicles\":" + Vehicles.GetJson() + ",\"portals\":" + Portals.GetJson() + ",\"graves\":" + Graves.GetJson()
                            + ",\"traders\":" + Traders.Json() + ",\"deaths\":" + Stats.DeathsJson()
                            + ",\"structures\":" + StructureMap.GetStats() + ",\"forest\":" + ForestMap.GetStats() + "}";
                        res.Headers.Add(HttpResponseHeader.CacheControl, "no-cache");
                        res.ContentType = "application/json";
                        res.StatusCode = 200;
                        textBytes = Encoding.UTF8.GetBytes(state);
                        res.ContentLength64 = textBytes.Length;
                        res.Close(textBytes, true);
                        return true;
                    }
                case "/stats/players":
                    res.Headers.Add(HttpResponseHeader.CacheControl, "no-cache");
                    res.ContentType = "application/json";
                    res.StatusCode = 200;
                    textBytes = Encoding.UTF8.GetBytes(Stats.Json(PinsByName()));
                    res.ContentLength64 = textBytes.Length;
                    res.Close(textBytes, true);
                    return true;
                case "/items":
                    // the game's own data for the items a page shows: the same for the whole
                    // run once ObjectDB is read, so an edge may keep it a while; not before
                    {
                        string body = Items.Json(req.QueryString["ids"], out string err);
                        res.Headers.Add(HttpResponseHeader.CacheControl, err == null && Items.Ready ? "public, max-age=3600" : "no-cache");
                        Answer(res, err == null ? 200 : 400, err == null ? body : "{\"error\":\"" + JsonEscape(err) + "\"}");
                        return true;
                    }
                case "/structures/stats":
                    res.Headers.Add(HttpResponseHeader.CacheControl, "no-cache");
                    res.ContentType = "application/json";
                    res.StatusCode = 200;
                    textBytes = Encoding.UTF8.GetBytes(StructureMap.GetStats());
                    res.ContentLength64 = textBytes.Length;
                    res.Close(textBytes, true);
                    return true;
                case "/settings":
                    // The settings an admin changes from the site.
                    {
                        if (!Caller(req, out string who, out bool admin) || !admin) { Answer(res, 403, "{\"error\":\"forbidden\"}"); return true; }
                        if (req.HttpMethod != "POST") { Answer(res, 200, Settings.Json()); return true; }
                        string body;
                        using (var sr = new StreamReader(req.InputStream, Encoding.UTF8)) body = sr.ReadToEnd();
                        string log = null; bool restart = false;
                        string err = Features.ParseBody(body, out string key, out string value, "key", "value")
                            ? Settings.Set(key, value, who, out log, out restart) : "expected {\"key\":..,\"value\":..}";
                        Answer(res, err == null ? 200 : 400, err == null
                            ? "{\"ok\":true,\"restart\":" + (restart ? "true" : "false") + ",\"log\":\"" + JsonEscape(log ?? "") + "\",\"settings\":" + Settings.Json() + "}"
                            : "{\"error\":\"" + JsonEscape(err) + "\"}");
                        return true;
                    }
                case "/discord/guilds":
                    // The bot's own guilds, for the settings picker; same gate as /settings.
                    // Empty (never an error) when there is no token yet, so the picker
                    // just falls back to the plain field.
                    {
                        if (!Caller(req, out _, out bool admin) || !admin) { Answer(res, 403, "{\"error\":\"forbidden\"}"); return true; }
                        Answer(res, 200, "{\"guilds\":" + RefsJson(Discord.Guilds()) + "}");
                        return true;
                    }
                case "/discord/channels":
                    // A guild's text channels, for the same picker.
                    {
                        if (!Caller(req, out _, out bool admin) || !admin) { Answer(res, 403, "{\"error\":\"forbidden\"}"); return true; }
                        string guild = req.QueryString["guild"];
                        if (string.IsNullOrEmpty(guild)) { Answer(res, 400, "{\"error\":\"guild is required\"}"); return true; }
                        Answer(res, 200, "{\"channels\":" + RefsJson(Discord.Channels(guild)) + "}");
                        return true;
                    }
                case "/at":
                    // what is at a spot, for a click on the map; nothing for unwalked ground
                    {
                        res.Headers.Add(HttpResponseHeader.CacheControl, "no-cache");
                        res.ContentType = "application/json";
                        string body = null;
                        if (float.TryParse(req.QueryString["x"], NumberStyles.Float, CultureInfo.InvariantCulture, out float ax)
                            && float.TryParse(req.QueryString["z"], NumberStyles.Float, CultureInfo.InvariantCulture, out float az))
                            body = Features.At(ax, az);
                        res.StatusCode = body == null ? 404 : 200;
                        textBytes = Encoding.UTF8.GetBytes(body ?? "{\"error\":\"unexplored\"}");
                        res.ContentLength64 = textBytes.Length;
                        res.Close(textBytes, true);
                        return true;
                    }
                case "/features":
                    // the world's geography with its names, the walked part of it only (Features.WalkedJson)
                    res.Headers.Add(HttpResponseHeader.CacheControl, "no-cache");
                    res.ContentType = "application/json";
                    res.StatusCode = 200;
                    textBytes = Encoding.UTF8.GetBytes(Features.WalkedJson());
                    res.ContentLength64 = textBytes.Length;
                    res.Close(textBytes, true);
                    return true;
                case "/names":
                    // A name given on the site, by a signed-in member.
                    {
                        if (!SiteWrite(req, res, out string body, out string who)) return true;
                        string log = null;
                        string err = !Features.ParseBody(body, out string id, out string name) ? "expected {\"id\":..,\"name\":..}"
                            : id.StartsWith("base@") ? Tiles.Markers.NameBase(id, Features.CleanName(name), Body.Bool(body, "hidden"), who ?? "", out log)
                            : Features.SetName(id, name, who, out log);
                        Answer(res, err == null ? 200 : 400, err == null
                            ? "{\"ok\":true,\"rev\":" + FeaturesRev() + ",\"log\":\"" + JsonEscape(log ?? "") + "\"}"
                            : "{\"error\":\"" + JsonEscape(err) + "\"}");
                        return true;
                    }
                case "/auth/login":
                    // A sign-in starts at the service, which sends the person back to `to`
                    // with #session=; the viewer keeps that and sends it as a bearer.
                    {
                        if (!SignInHere(req, out var origins)) { Answer(res, 404, "{\"error\":\"sign-in is not configured\"}"); return true; }
                        string url = Auth.LoginUrl(WebMapConfig.AUTH_URL, req.QueryString["to"] ?? "", WebMapConfig.DISCORD_GUILD, origins);
                        if (url == null) { Answer(res, 400, "{\"error\":\"bad return address\"}"); return true; }
                        res.Headers.Add(HttpResponseHeader.CacheControl, "no-store");
                        res.RedirectLocation = url;
                        res.StatusCode = 302;
                        res.Close();
                        return true;
                    }
                case "/auth/me":
                    // a 404 keeps the viewer's Sign in hidden where sign-in is off
                    {
                        if (!SignInHere(req, out _)) { Answer(res, 404, "{\"error\":\"sign-in is not configured\"}"); return true; }
                        res.Headers.Add(HttpResponseHeader.CacheControl, "no-store");
                        var s = Signed(req, out bool admin);
                        if (s == null) { Answer(res, 401, "{\"error\":\"not signed in\"}"); return true; }
                        Answer(res, 200, "{\"id\":\"" + JsonEscape(s.Id) + "\",\"name\":\"" + JsonEscape(s.Name) + "\",\"avatar\":"
                            + (string.IsNullOrEmpty(s.Avatar) ? "null" : "\"" + JsonEscape(s.Avatar) + "\"") + ",\"admin\":" + (admin ? "true" : "false") + "}");
                        return true;
                    }
                case "/announce":
                    // Shared-secret only, and deliberately absent from the public
                    // Worker's allowlist: this writes into everyone's chat.
                    {
                        if (!Auth.Same(Announce.Token, req.Headers["X-Announce-Token"] ?? ""))
                        {
                            res.StatusCode = 403;
                            textBytes = Encoding.UTF8.GetBytes("{\"error\":\"forbidden\"}");
                            res.ContentType = "application/json";
                            res.ContentLength64 = textBytes.Length;
                            res.Close(textBytes, true);
                            return true;
                        }
                        string body;
                        using (var sr = new StreamReader(req.InputStream, Encoding.UTF8))
                            body = sr.ReadToEnd();
                        body = (body ?? "").Trim();
                        if (body.Length == 0)
                        {
                            res.StatusCode = 400;
                            textBytes = Encoding.UTF8.GetBytes("{\"error\":\"empty\"}");
                            res.ContentType = "application/json";
                            res.ContentLength64 = textBytes.Length;
                            res.Close(textBytes, true);
                            return true;
                        }
                        Announce.Enqueue(body);
                        res.ContentType = "application/json";
                        res.StatusCode = 202;
                        textBytes = Encoding.UTF8.GetBytes("{\"queued\":true}");
                        res.ContentLength64 = textBytes.Length;
                        res.Close(textBytes, true);
                        return true;
                    }
                case "/pins":
                    // A POST places, changes or takes up a pin from the site, guarded like /names.
                    if (req.HttpMethod == "POST")
                    {
                        if (!SiteWrite(req, res, out string body, out string who)) return true;
                        string err = WritePin(body, who, out string pinId, out string log);
                        Answer(res, err == null ? 200 : 400, err == null
                            ? "{\"ok\":true,\"id\":\"" + JsonEscape(pinId) + "\",\"pins\":" + PinsJson() + ",\"log\":\"" + JsonEscape(log ?? "") + "\"}"
                            : "{\"error\":\"" + JsonEscape(err) + "\"}");
                        return true;
                    }
                    res.Headers.Add(HttpResponseHeader.CacheControl, "no-cache");
                    res.ContentType = "text/csv";
                    res.StatusCode = 200;
                    string text;
                    lock (pins) text = string.Join("\n", pins);
                    textBytes = Encoding.UTF8.GetBytes(text);
                    res.ContentLength64 = textBytes.Length;
                    res.Close(textBytes, true);
                    return true;
            }

            return false;
        }

        // A write from the site. False when this has already answered 403.
        private static bool SiteWrite(HttpListenerRequest req, HttpListenerResponse res, out string body, out string who)
        {
            body = who = null;
            if (req.HttpMethod != "POST" || !Caller(req, out who, out _))
            {
                Answer(res, 403, "{\"error\":\"forbidden\"}");
                return false;
            }
            using (var sr = new StreamReader(req.InputStream, Encoding.UTF8))
                body = sr.ReadToEnd();
            return true;
        }

        // Who is writing. A proxy holding the shared token (our Worker) says who in X-User
        // and whether an admin in X-Admin, never believed without it; a browser signed in
        // through the sign-in service carries its session. False when neither.
        private static bool Caller(HttpListenerRequest req, out string who, out bool admin)
        {
            if (Auth.Same(Announce.Token, req.Headers["X-Announce-Token"] ?? ""))
            {
                who = req.Headers["X-User"] ?? "";
                try { who = Uri.UnescapeDataString(who); } catch { }
                admin = req.Headers["X-Admin"] == "1";
                return true;
            }
            var s = Signed(req, out admin);
            who = s?.Name;
            return s != null;
        }

        // The session a request's bearer carries, checked against the service's key, this
        // map's Discord server and this map's addresses; null where sign-in is off.
        private static Auth.Session Signed(HttpListenerRequest req, out bool admin)
        {
            admin = false;
            string h = req.Headers["Authorization"] ?? "";
            if (!h.StartsWith("Bearer ", StringComparison.OrdinalIgnoreCase) || !SignInHere(req, out var origins)) return null;
            var s = Auth.Verify(h.Substring(7).Trim(), WebMapConfig.AUTH_PUBLIC_KEY.Length > 0 ? WebMapConfig.AUTH_PUBLIC_KEY : Auth.BrokerKey,
                                WebMapConfig.DISCORD_GUILD, origins, DateTimeOffset.UtcNow.ToUnixTimeSeconds(), WebMapConfig.SIGN_OUT_BEFORE);
            if (s != null) admin = Auth.IsAdmin(s.Owner, s.Perms, s.Roles, WebMapConfig.DISCORD_ADMIN_ROLE);
            return s;
        }

        // Whether this caller can sign in: discord_guild set, and an address of this map's
        // own it can be at. A remote caller has none until public_url is set or the game
        // knows its public address, and is told sign-in is off.
        private static bool signInWarned;
        private static bool SignInHere(HttpListenerRequest req, out List<string> origins)
        {
            origins = null;
            if (WebMapConfig.DISCORD_GUILD.Length == 0) return false;
            origins = Auth.Origins(req.Headers["Host"], req.RemoteEndPoint?.Address, WebMapConfig.PUBLIC_URL, publicIp, SERVER_PORT);
            if (origins.Count > 0) return true;
            if (!signInWarned)
            {
                signInWarned = true;
                ZLog.LogWarning("WebMap: sign-in is off for visitors from outside until the game says its public address; a map reached by a name or through a proxy needs public_url");
            }
            return false;
        }

        // The server's public address as the game knows it: PlayFab looks it up for a
        // crossplay server, Steam reports what it sees of a Steam one once logged on.
        // Game thread only; the HTTP threads read the string.
        private static volatile string publicIp;
        private static void LearnPublicIp()
        {
            string ip = null;
            try { ip = ZPlayFabMatchmaking.PublicIP; } catch { }
            if (string.IsNullOrEmpty(ip))
                try { if (Steamworks.SteamGameServer.BLoggedOn()) { var a = Steamworks.SteamGameServer.GetPublicIP(); if (a.IsSet()) ip = a.ToString(); } } catch { }
            if (string.IsNullOrEmpty(ip) || ip == publicIp) return;
            publicIp = ip;
            ZLog.Log($"WebMap: the game says its public address is {ip}; sign-in answers at http://{(ip.Contains(":") ? "[" + ip + "]" : ip)}:{SERVER_PORT}");
        }

        // A body, gzipped for a client that takes it: the 3D view's chunks are arrays of
        // numbers that shrink to a third. Each body is compressed once and kept with it.
        private static readonly System.Runtime.CompilerServices.ConditionalWeakTable<byte[], byte[]> gzipped =
            new System.Runtime.CompilerServices.ConditionalWeakTable<byte[], byte[]>();
        // A static file is read afresh on every request when cache_server_files is off, so
        // its gzip is kept by name and file time instead.
        private static readonly System.Collections.Concurrent.ConcurrentDictionary<string, Tuple<DateTime, byte[]>> staticGz =
            new System.Collections.Concurrent.ConcurrentDictionary<string, Tuple<DateTime, byte[]>>();
        private static bool TakesGzip(HttpListenerRequest req, byte[] body) =>
            body.Length > 1024 && (req.Headers["Accept-Encoding"] ?? "").IndexOf("gzip", StringComparison.OrdinalIgnoreCase) >= 0;
        private static byte[] Gzip(byte[] raw)
        {
            using (var ms = new MemoryStream(raw.Length / 3))
            {
                using (var gz = new System.IO.Compression.GZipStream(ms, System.IO.Compression.CompressionMode.Compress, true)) gz.Write(raw, 0, raw.Length);
                return ms.ToArray();
            }
        }
        private static void SendBytes(HttpListenerRequest req, HttpListenerResponse res, byte[] body, string contentType, bool compressible = true)
        {
            byte[] gz = compressible && TakesGzip(req, body) ? gzipped.GetValue(body, Gzip) : null;
            Send(res, body, gz, contentType);
        }
        private static void Send(HttpListenerResponse res, byte[] body, byte[] gz, string contentType)
        {
            if (gz != null) { body = gz; res.Headers.Add("Content-Encoding", "gzip"); }
            res.Headers.Add("Vary", "Accept-Encoding");
            res.ContentType = contentType;
            res.StatusCode = 200;
            res.ContentLength64 = body.Length;
            res.Close(body, true);
        }

        // What the static files' memory cache may hold: small files only (the viewer's own
        // pages and scripts), never a big one and never anything under an hd/ folder, so the
        // optional full-quality textures cost the server disk, not RAM.
        internal const long CacheMax = 256 * 1024;
        internal static bool Cacheable(string requestedFile, long length) =>
            length <= CacheMax && Array.IndexOf((requestedFile ?? "").Split('/'), Models.HdMaps.Dir) < 0;

        // /models/<file>: a model (<hash>.glb) or a texture (tex_<name>.png) from the
        // library, by name only. The mesh cache beside them is game data and never served.
        // /models/hd/<file>: the full-quality maps, see ServeHd.
        private static readonly System.Text.RegularExpressions.Regex ModelFile =
            new System.Text.RegularExpressions.Regex(@"^([0-9a-f]{8}\.glb|tex_[A-Za-z0-9_-]{1,120}\.png)$");
        private static void ServeModel(HttpListenerRequest req, HttpListenerResponse res, string name)
        {
            string root = Models.ModelStore.Root;
            if (name.StartsWith(Models.HdMaps.Dir + "/", StringComparison.Ordinal)) { ServeHd(req, res, Models.HdMaps.PathOf(root, name.Substring(Models.HdMaps.Dir.Length + 1))); return; }
            string path = root != null && ModelFile.IsMatch(name) ? Path.Combine(root, name) : null;
            byte[] body = null;
            DateTime stamp = DateTime.MinValue;
            try { if (path != null && File.Exists(path)) { stamp = File.GetLastWriteTimeUtc(path); body = File.ReadAllBytes(path); } } catch { }
            if (body == null) { Answer(res, 404, "{\"error\":\"no such model\"}"); return; }
            // a re-export writes a new file: its time is the version
            string etag = "\"" + stamp.Ticks.ToString("x", CultureInfo.InvariantCulture) + "\"";
            res.Headers.Add(HttpResponseHeader.CacheControl, "public, max-age=86400");
            res.Headers.Add(HttpResponseHeader.ETag, etag);
            if (req.Headers["If-None-Match"] == etag) { res.StatusCode = 304; res.Close(); return; }
            bool glb = name.EndsWith(".glb", StringComparison.Ordinal);
            SendBytes(req, res, body, glb ? "model/gltf-binary" : "image/png", compressible: glb);
        }

        // /tiles/{map,terra,veg,height}/{z}/{x}/{y}.png, Munin's pyramid (Tiles/TileStore). A tile not
        // drawn yet is a 404 marked pending, and is queued if anyone can see it. Stored as lossless
        // WebP where it can be; the URL still says .png, so a browser that does not take WebP (it
        // says so in Accept) gets the same pixels as a PNG made on the spot.
        internal static bool ParseTile(string path, out string layer, out int z, out int x, out int y)
        {
            layer = null; z = x = y = 0;
            string[] p = path.Split('/');
            if (p.Length != 6 || p[0] != "" || p[1] != "tiles" || !p[5].EndsWith(".png", StringComparison.Ordinal)) return false;
            layer = p[2];
            if (layer != "map" && layer != "height" && layer != "veg" && layer != "terra") return false;
            return int.TryParse(p[3], NumberStyles.None, CultureInfo.InvariantCulture, out z)
                && int.TryParse(p[4], NumberStyles.None, CultureInfo.InvariantCulture, out x)
                && int.TryParse(p[5].Substring(0, p[5].Length - 4), NumberStyles.None, CultureInfo.InvariantCulture, out y);
        }

        private static void ServeTile(HttpListenerRequest req, HttpListenerResponse res, string path)
        {
            if (!ParseTile(path, out string layer, out int z, out int x, out int y)) { Answer(res, 404, "{\"error\":\"no such tile\"}"); return; }
            byte[] data = Tiles.TileStore.Get(layer, z, x, y, out string etag);
            if (data == null)
            {
                res.Headers.Add("X-Munin-Tile", "pending");
                res.Headers.Add(HttpResponseHeader.CacheControl, "no-store");
                Answer(res, 404, "{\"error\":\"not drawn yet\"}");
                return;
            }
            // tiles hardly ever change: reused for 10 minutes without asking, then shown from cache
            // while checked again; a re-render reaches open pages over the websocket
            res.Headers.Add(HttpResponseHeader.CacheControl, "public, max-age=600, stale-while-revalidate=2592000");
            string type = "image/png";
            if (Util.WebP.IsWebp(data))
            {
                res.Headers.Add(HttpResponseHeader.Vary, "Accept");
                if ((req.Headers["Accept"] ?? "").Contains("image/webp")) type = "image/webp";
                else
                {
                    data = Util.WebP.ToPng(data);
                    if (data == null) { Answer(res, 500, "{\"error\":\"tile conversion failed\"}"); return; }
                    etag = "\"p" + etag.Substring(1);
                }
            }
            res.Headers.Add(HttpResponseHeader.ETag, etag);
            if (req.Headers["If-None-Match"] == etag) { res.StatusCode = 304; res.Close(); return; }
            res.ContentType = type;
            res.StatusCode = 200;
            res.ContentLength64 = data.Length;
            res.Close(data, true);
        }

        // /data/..., Munin's map data, the paths its page asks for. Everything is over walked ground
        // only: the fog filters it where it is built (Structures, Ruins, Vegetation, BiomeMap).
        // What ForgeMap does not serve yet (markers, stats, events...) is a 404 the page shrugs off.
        private void ServeData(HttpListenerRequest req, HttpListenerResponse res, string rest)
        {
            if (rest.StartsWith("veg/", StringComparison.Ordinal)) { ServeVegetation(req, res, rest.Substring(4)); return; }
            string json = null; byte[] bin = null; string type = "application/octet-stream";
            switch (rest)
            {
                case "fog.png":                       // the same mask as /fog: 2048 cells of 12 m, north up
                {
                    byte[] fog = GetFogPng();
                    if (fog.Length == 0) { Answer(res, 503, "{\"error\":\"not ready\"}"); return; }   // never a cacheable empty 200
                    res.Headers.Add(HttpResponseHeader.CacheControl, "no-cache");
                    SendBytes(req, res, fog, "image/png", compressible: false);
                    return;
                }
                case "structures/index.json": json = Tiles.Structures.IndexJson; break;
                case "ruins/index.json": json = Tiles.Ruins.IndexJson; break;
                case "biomes.json": json = Tiles.BiomeMap.LabelsJson(); break;
                case "biomes.grid": bin = Tiles.BiomeMap.GridFor(); break;
                case "biomes.png": bin = Tiles.BiomeMap.PngFor(); type = "image/png"; break;
                case "mist.png": bin = Tiles.BiomeMap.MistPngFor(); type = "image/png"; break;
                // the 3D view: ForgeMap's objects and model library, at Munin's paths and in its numbering
                case "objects/index.json": json = WorldObjects.MuninIndexJson(MuninChunkShift); break;
                case "prefabs.json": json = Models.ModelStore.PrefabsJson; break;
                case "environments.json": json = Weather.EnvironmentsJson(); break;   // each weather's light, for the 3D sky
                // the Activity layers: trails of the last hours, time spent and deaths per 64 m zone
                case "activity.json":
                    {
                        int.TryParse(req.QueryString["hours"] ?? "3", NumberStyles.Integer, CultureInfo.InvariantCulture, out int hours);
                        json = Activity.Json(hours); res.Headers.Add(HttpResponseHeader.CacheControl, "no-cache");
                        break;
                    }
                case "activity/zone.json":
                    {
                        int.TryParse(req.QueryString["zx"] ?? "", NumberStyles.Integer, CultureInfo.InvariantCulture, out int zx);
                        int.TryParse(req.QueryString["zz"] ?? "", NumberStyles.Integer, CultureInfo.InvariantCulture, out int zz);
                        json = Activity.ZoneJson(zx, zz); res.Headers.Add(HttpResponseHeader.CacheControl, "no-cache");
                        break;
                    }
                case "icons.json": json = Tiles.MapIcons.ManifestJson; res.Headers.Add(HttpResponseHeader.CacheControl, "no-cache"); break;   // the game's map icons
                case "items.json": json = Tiles.ItemIcons.NamesJson; break;   // each item's name in the game
                case "hotspots.json": json = Tiles.Hotspots.Json; res.Headers.Add(HttpResponseHeader.CacheControl, "no-cache"); break;
                case "building.json":
                    {
                        int.TryParse(req.QueryString["days"] ?? "1", NumberStyles.Integer, CultureInfo.InvariantCulture, out int days);
                        json = Tiles.BuildHistory.Json(days); res.Headers.Add(HttpResponseHeader.CacheControl, "no-cache");
                        break;
                    }
                case "stats.json": json = Weather.StatsJson; res.Headers.Add(HttpResponseHeader.CacheControl, "no-cache"); break;   // the world's clock and forecast
                case "pins.json": json = PinsMuninJson(); break;
                case "markers.json": json = Tiles.Markers.Json; break;   // Munin's marker sets (Tiles/Markers)
                case "mistclear.json": json = Tiles.Demisters.Json(); break;   // where Dvergr lanterns clear the mist
                // the Events panel: what a page opening (or back after a gap) needs, then older history
                case "hello.json": json = HelloJson(WorldEvents.RaidJson, WorldEvents.InvasionsJson, Feed.RecentJson); res.Headers.Add(HttpResponseHeader.CacheControl, "no-cache"); break;
                case "events/older.json":
                    {
                        if (!int.TryParse(req.QueryString["limit"] ?? "100", NumberStyles.Integer, CultureInfo.InvariantCulture, out int limit)) limit = 100;
                        json = Feed.OlderJson(req.QueryString["before"] ?? DateTime.UtcNow.ToString("o", CultureInfo.InvariantCulture), Math.Max(1, Math.Min(500, limit)));
                        res.Headers.Add(HttpResponseHeader.CacheControl, "no-cache");
                        break;
                    }
            }
            if (json == null && bin == null && rest.StartsWith("objects/", StringComparison.Ordinal) && rest.EndsWith(".bin", StringComparison.Ordinal))
            {
                // objects/{cx}_{cz}.bin in Munin's numbering: ForgeMap's OBJ2 of that chunk (the page reads it)
                if (ParseChunk(rest.Substring(8, rest.Length - 12), out int mcx, out int mcz))
                    bin = WorldObjects.ChunkBytes(mcx - MuninChunkShift, mcz - MuninChunkShift, out _);
                if (bin == null) { Answer(res, 404, "{\"error\":\"nothing walked there\"}"); return; }
            }
            if (json == null && bin == null && rest.EndsWith(".json", StringComparison.Ordinal))
            {
                // structures/{cx}_{cz}.json, structures/r/{rx}_{rz}.json, and the same for ruins
                bool st = rest.StartsWith("structures/", StringComparison.Ordinal), ru = rest.StartsWith("ruins/", StringComparison.Ordinal);
                string id = st || ru ? rest.Substring(st ? 11 : 6, rest.Length - (st ? 11 : 6) - 5) : null;
                int rev = 0;
                if (id != null && id.StartsWith("r/", StringComparison.Ordinal))
                {
                    if (Tiles.Regions.Parse(id.Substring(2), out int rx, out int rz))
                        json = st ? Tiles.Structures.RegionJson(rx, rz, out rev) : Tiles.Ruins.RegionJson(rx, rz, out rev);
                }
                else if (id != null && ParseChunk(id, out int cx, out int cz))
                {
                    json = st ? Tiles.Structures.ChunkJson(cx, cz, out rev) : Tiles.Ruins.ChunkJson(cx, cz, out rev);
                    if (json == null && st) json = "{\"cx\":" + cx + ",\"cz\":" + cz + ",\"rev\":0,\"count\":0,\"pieces\":[],\"prefabs\":[]}";
                }
                if (json != null)
                {
                    // a region or chunk at its revision (?h=) is the same bytes for good
                    bool exact = req.QueryString["h"] == rev.ToString(CultureInfo.InvariantCulture);
                    res.Headers.Add(HttpResponseHeader.CacheControl, exact ? "public, max-age=31536000, immutable" : "no-cache");
                    SendBytes(req, res, Encoding.UTF8.GetBytes(json), "application/json");
                    return;
                }
            }
            if (json == null && bin == null) { Answer(res, 404, "{\"error\":\"no such data\"}"); return; }
            res.Headers.Add(HttpResponseHeader.CacheControl, "no-cache");
            if (json != null) SendBytes(req, res, Encoding.UTF8.GetBytes(json), "application/json");
            else SendBytes(req, res, bin, type, compressible: type != "image/png");
        }

        // the revision of /features as served: the walked places move with the fog, not only with names
        private static int FeaturesRev() { Features.WalkedJson(); return Features.WalkedRev; }

        // Munin numbers 256 m chunks from the world's south-west corner (TileMath.ChunkCoord), ForgeMap
        // from its middle (WorldObjects.ChunkOf): the same squares, 42 apart (10752 m / 256)
        internal const int MuninChunkShift = Tiles.TileMath.WORLD_HALF / Tiles.TileMath.CHUNK_SIZE;

        // "cx_cz", two chunk numbers inside the grid
        internal static bool ParseChunk(string s, out int cx, out int cz)
        {
            cx = cz = 0;
            int us = s.IndexOf('_');
            return us > 0 && int.TryParse(s.Substring(0, us), NumberStyles.None, CultureInfo.InvariantCulture, out cx)
                && int.TryParse(s.Substring(us + 1), NumberStyles.None, CultureInfo.InvariantCulture, out cz)
                && cx < Tiles.TileMath.ChunksPerSide && cz < Tiles.TileMath.ChunksPerSide;
        }

        // /data/veg/index.json, /data/veg/r3/{rx}_{rz}.bin (a 4x4-chunk region, cached for good at
        // its ?h=), /data/veg/{cx}_{cz}.bin (one chunk): trees and rocks over walked ground only
        private static void ServeVegetation(HttpListenerRequest req, HttpListenerResponse res, string rest)
        {
            if (rest == "index.json")
            {
                res.Headers.Add(HttpResponseHeader.CacheControl, "no-cache");
                SendBytes(req, res, Encoding.UTF8.GetBytes(Tiles.Vegetation.IndexJson()), "application/json");
                return;
            }
            if (!rest.EndsWith(".bin", StringComparison.Ordinal)) { Answer(res, 404, "{\"error\":\"no such data\"}"); return; }
            if (rest.StartsWith("r3/", StringComparison.Ordinal))
            {
                string id = rest.Substring(3, rest.Length - 7);
                byte[] bin = null; int rev = 0;
                if (Tiles.Regions.Parse(id, out int rx, out int rz, Tiles.Vegetation.REGION)) bin = Tiles.Vegetation.RegionBin(rx, rz, out rev);
                if (bin == null) { Answer(res, 404, "{\"error\":\"nothing walked there\"}"); return; }
                bool exact = req.QueryString["h"] == rev.ToString(CultureInfo.InvariantCulture);
                res.Headers.Add(HttpResponseHeader.CacheControl, exact ? "public, max-age=31536000, immutable" : "no-cache");
                SendBytes(req, res, bin, "application/octet-stream");
                return;
            }
            if (!ParseChunk(rest.Substring(0, rest.Length - 4), out int cx, out int cz)) { Answer(res, 404, "{\"error\":\"no such chunk\"}"); return; }
            float minX = Tiles.TileMath.ChunkMin(cx), minZ = Tiles.TileMath.ChunkMin(cz);
            if (!MapFog.AnyExplored(minX, minZ, minX + Tiles.TileMath.CHUNK_SIZE, minZ + Tiles.TileMath.CHUNK_SIZE))
            { Answer(res, 404, "{\"error\":\"nothing walked there\"}"); return; }
            res.Headers.Add(HttpResponseHeader.CacheControl, "public, max-age=600");
            SendBytes(req, res, Tiles.Vegetation.Chunk(cx, cz), "application/octet-stream");
        }

        // A full-quality map (or the folder's index.json), streamed from disk a piece at a time:
        // never read whole, never cached, never gzipped (PNG is compressed already). The viewer
        // asks for each map with ?v=<its version from index.json>, so a map is kept a week; the
        // index itself a few minutes, so a new run of the tool shows soon. No folder: 404.
        internal static void ServeHd(HttpListenerRequest req, HttpListenerResponse res, string path)
        {
            FileInfo fi = null;
            try { if (path != null) { fi = new FileInfo(path); if (!fi.Exists) fi = null; } } catch { fi = null; }
            if (fi == null) { Answer(res, 404, "{\"error\":\"no such map\"}"); return; }
            bool index = path.EndsWith(".json", StringComparison.Ordinal);
            string etag = "\"" + fi.LastWriteTimeUtc.Ticks.ToString("x", CultureInfo.InvariantCulture) + "-" + fi.Length.ToString("x", CultureInfo.InvariantCulture) + "\"";
            res.Headers.Add(HttpResponseHeader.CacheControl, index ? "public, max-age=300" : "public, max-age=604800, immutable");
            res.Headers.Add(HttpResponseHeader.ETag, etag);
            if (req.Headers["If-None-Match"] == etag) { res.StatusCode = 304; res.Close(); return; }
            try
            {
                using (var fs = new FileStream(path, FileMode.Open, FileAccess.Read, FileShare.ReadWrite | FileShare.Delete, Models.HdMaps.Chunk))
                {
                    res.ContentType = index ? "application/json" : "image/png";
                    res.StatusCode = 200;
                    res.SendChunked = true;           // websocket-sharp sends a chunked body as it is flushed, a fixed-length one only whole
                    Models.HdMaps.Copy(fs, res.OutputStream);
                }
            }
            catch (Exception e) { if (WebMapConfig.DEBUG) ZLog.LogWarning("WebMap: hd map " + Path.GetFileName(path) + ": " + e.Message); }
            try { res.Close(); } catch { }
        }

        // [{"id","name"}, ...] for the settings picker's two Discord lookups.
        private static string RefsJson(List<DiscordRef> refs)
        {
            var sb = new StringBuilder("[");
            for (int i = 0; i < refs.Count; i++)
            {
                if (i > 0) sb.Append(',');
                sb.Append("{\"id\":\"").Append(JsonEscape(refs[i].Id)).Append("\",\"name\":\"").Append(JsonEscape(refs[i].Name)).Append("\"}");
            }
            return sb.Append(']').ToString();
        }

        private static void Answer(HttpListenerResponse res, int status, string json)
        {
            res.ContentType = "application/json";
            res.StatusCode = status;
            byte[] b = Encoding.UTF8.GetBytes(json);
            res.ContentLength64 = b.Length;
            res.Close(b, true);
        }

        public string PinsJson()
        {
            lock (pins)
            {
                var q = new List<string>(pins.Count);
                foreach (string line in pins) q.Add("\"" + JsonEscape(line) + "\"");
                return "[" + string.Join(",", q) + "]";
            }
        }

        // Pins from the site. Any signed-in member may change any pin -- one party --
        // and the log says who did what. A site pin's placer field is "web", where a
        // game pin has its player's platform id: the chat commands match on that id,
        // so they never reach one. Its id is "w" + a millisecond stamp, apart from the
        // game's "<seconds>-<random>". Null when the write took, else what was wrong.
        public const string SitePlacer = "web";
        private static readonly System.Text.RegularExpressions.Regex Unprintable =
            new System.Text.RegularExpressions.Regex(@"[\p{Cc}\p{Cf}]");
        public string WritePin(string body, string who, out string id) => WritePin(body, who, out id, out _);
        public string WritePin(string body, string who, out string id, out string log)
        {
            log = null;
            string op = Body.Str(body, "op");
            id = Body.Str(body, "id");
            // the owner is a CSV field, so no commas; 32 is Discord's own cap on a name
            who = Unprintable.Replace(who ?? "", "").Replace(",", "").Trim();
            if (who.Length > 32) who = who.Substring(0, 32).Trim();
            if (who.Length == 0) who = "someone";
            if (op != "add" && op != "edit" && op != "delete") return "op is add, edit or delete";

            string type = Body.Str(body, "type"), text = Body.Str(body, "text");
            if (type != null && Array.IndexOf(WebMap.ALLOWED_PINS, type) < 0)
                return "type is one of " + string.Join(", ", WebMap.ALLOWED_PINS);
            if (text != null)
            {
                text = Unprintable.Replace(text, "").Trim();
                if (text.Length > 60) return "a pin's text is at most 60 characters";
            }
            bool moves = op == "add" || Body.Has(body, "x") || Body.Has(body, "z");
            double x = Body.Num(body, "x"), z = Body.Num(body, "z");
            if (moves)
            {
                if (!(Math.Abs(x) <= 12000 && Math.Abs(z) <= 12000)) return "x and z are numbers within 12000 m of the centre";
                // the honour system: the site pins only ground somebody has walked
                if (!MapFog.Explored((float)x, (float)z)) return "nobody has walked there yet";
            }
            string sx = FixedValue((float)x), sz = FixedValue((float)z);

            string[] was = null, now = null;
            lock (pins)
            {
                if (op == "add")
                {
                    long t = DateTimeOffset.UtcNow.ToUnixTimeMilliseconds();
                    do id = "w" + t++; while (FindPin(id) >= 0);
                    string line = $"{SitePlacer},{id},{type ?? "dot"},{who},{sx},{sz},{text ?? ""}";
                    pins.Add(line);
                    now = line.Split(',');
                }
                else
                {
                    int i = string.IsNullOrEmpty(id) ? -1 : FindPin(id);
                    if (i < 0) return "no such pin";
                    was = pins[i].Split(',');
                    if (op == "delete") pins.RemoveAt(i);
                    else
                    {
                        string line = $"{was[0]},{was[1]},{type ?? was[2]},{was[3]},{(moves ? sx : was[4])},{(moves ? sz : was[5])},{text ?? PinText(was)}";
                        pins[i] = line;
                        now = line.Split(',');
                    }
                }
            }
            WebMap.SavePins();

            // the websocket feed carries pins as they come and go; the pin is saved
            // by now, so a feed that cannot take it must not fail the write
            try
            {
                if (was != null) webSocketHandler.Sessions.Broadcast($"rmpin\n{was[1]}");
                if (now != null)
                    webSocketHandler.Sessions.Broadcast($"pin\n{now[0]}\n{now[1]}\n{now[2]}\n{now[3]}\n{now[4]},{now[5]}\n{PinText(now)}");
            }
            catch (Exception e) { if (WebMapConfig.DEBUG) ZLog.LogWarning("WebMap: pin not broadcast: " + e.Message); }

            if (op == "add")
                try { Feed.Add("pin", now[3], "placed a pin" + (PinText(now).Length > 0 ? ": " + PinText(now) : ""), (float)x, (float)z); } catch { }
            if (op == "add")
                log = $"{who} pinned a {now[2]} '{PinText(now)}' at {sx}, {sz}";
            else if (op == "delete")
                log = $"{who} took up {was[3]}'s {was[2]} pin '{PinText(was)}'";
            else
            {
                var what = new List<string>();
                if (now[2] != was[2]) what.Add("a " + now[2]);
                if (PinText(now) != PinText(was)) what.Add($"'{PinText(now)}'");
                if (now[4] != was[4] || now[5] != was[5]) what.Add($"moved to {now[4]}, {now[5]}");
                log = $"{who} changed {was[3]}'s pin '{PinText(was)}': " + (what.Count > 0 ? string.Join(", ", what) : "no change");
            }
            ZLog.Log("WebMap: " + log + " from the site");
            Discord.Tell(log);
            return null;
        }
        // Munin's map: [{"id","type","name","x","z","text"}], the same pins as /pins. Never whose
        // browser placed one ("mine"): writes go by the signed-in member, whoever they are.
        internal string PinsMuninJson()
        {
            var j = new Util.JsonWriter(256);
            j.BeginArray();
            lock (pins)
                foreach (string line in pins)
                {
                    var f = line.Split(',');
                    if (f.Length < 6) continue;
                    if (!float.TryParse(f[4], NumberStyles.Float, CultureInfo.InvariantCulture, out float x)
                        || !float.TryParse(f[5], NumberStyles.Float, CultureInfo.InvariantCulture, out float z)) continue;
                    j.BeginObject().Prop("id", f[1]).Prop("type", f[2]).Prop("name", f[3]).Prop("x", x, 1).Prop("z", z, 1).Prop("text", PinText(f)).End();
                }
            j.End();
            return j.ToString();
        }

        // under lock (pins); a line is placer,id,type,owner,x,z,text
        private int FindPin(string id) => pins.FindIndex(l => { var f = l.Split(','); return f.Length >= 6 && f[1] == id; });
        // the text is last and may hold commas
        private static string PinText(string[] f) => f.Length > 6 ? string.Join(",", f, 6, f.Length - 6) : "";

        // Game thread only. Rebuilds what every other thread serves.
        private volatile int worldWindDeg = -1;         // degrees, -1 while unknown (read on the broadcast's thread)
        private float weatherAt = -10f;
        private static bool weatherWarned;

        public void RefreshPlayerSnapshot()
        {
            try
            {
                float now = Time.realtimeSinceStartup;
                foreach (var player in players) Ping.Sample(player, now);   // before the JSON that carries it
                playersWs = BuildPlayerResponse();
                playersJson = BuildPlayersJson(now);
                // the wind blows the same way everywhere (the page's arrow); the clock and forecast now and then
                try { worldWindDeg = Weather.At(Vector3.zero, out var ww) ? Mathf.RoundToInt(ww.windDeg) % 360 : -1; } catch { }
                if (now - weatherAt > 5f) { weatherAt = now; try { Weather.Refresh(); } catch (Exception e) { WarnOnce(ref weatherWarned, "the weather could not be read", e); } }
                var snaps = new List<Activity.Snap>();
                foreach (var player in players)
                {
                    ZDO z = null;
                    try { z = ZDOMan.instance.GetZDO(player.m_characterID); } catch { }
                    if (z == null) continue;
                    // the Activity layers: only who shows on the map, as the live dots
                    Vector3 at = z.GetPosition();
                    snaps.Add(new Activity.Snap { key = player.m_playerName, name = player.m_playerName, x = at.x, z = at.z,
                        hasPos = player.m_publicRefPos || WebMapConfig.ALWAYS_VISIBLE, dead = z.GetBool(ZDOVars.s_dead) });
                    long pid = 0L;
                    try { pid = z.GetLong(ZDOVars.s_playerID, 0L); } catch { }
                    float hp = -1f, maxHp = -1f;
                    try { maxHp = z.GetFloat(ZDOVars.s_maxHealth, -1f); hp = z.GetFloat(ZDOVars.s_health, -1f); } catch { }
                    Stats.Seen(player.m_playerName, pid, z.GetPosition(), hp, maxHp);
                    Gear.Sample(player.m_playerName, z, PLAYER_UPDATE_INTERVAL);
                    Trails.Mark(pid != 0L ? pid : player.m_playerName.GetHashCode(), z.GetPosition());
                }
                Activity.Sample(snaps);
            }
            catch (Exception ex) { WarnOnce(ref snapshotWarned, "player snapshot failed", ex); }
            // a failing snapshot must not also stop the tallies being saved
            try
            {
                Kitchen.Tick(Time.realtimeSinceStartup);    // catches its own, station by station
                Items.Index();                              // once ObjectDB has its items; a compare after
                LearnPublicIp();
                Stats.MaybeSave();
                Trails.MaybeSave();
                Activity.MaybeSave();
                timeJson = BuildTimeJson();
            }
            catch (Exception ex) { WarnOnce(ref saveWarned, "player snapshot's saves failed", ex); }
        }

        // Once a run: these run every second, and a fault that repeats would flood the log.
        private bool snapshotWarned, saveWarned, lookWarned;
        private static void WarnOnce(ref bool warned, string what, Exception e)
        {
            if (warned) return;
            warned = true;
            ZLog.LogWarning("WebMap: " + what + ": " + e);
        }

        // EnvMan.RescaleDayFraction's rule: the clock's 0.15..0.85 is daylight, stretched
        // to 0.25..0.75 so the sun is on the horizon at a quarter and three quarters.
        private static string BuildTimeJson()
        {
            if (ZNet.instance == null) return "null";
            double t = ZNet.instance.GetTimeSeconds();
            long len = EnvMan.instance != null && EnvMan.instance.m_dayLengthSec > 0 ? EnvMan.instance.m_dayLengthSec : 1200L;
            float f = (float)(t % len / len);
            if (f >= 0.15f && f <= 0.85f) f = 0.25f + (f - 0.15f) / 0.7f * 0.5f;
            else if (f < 0.5f) f = f / 0.15f * 0.25f;
            else f = 0.75f + (f - 0.85f) / 0.15f * 0.25f;
            return FormattableString.Invariant($"{{\"day\":{(long)(t / len)},\"frac\":{f:0.0000}}}");
        }

        public void Reload()
        {
            forceReload = true;
        }

        public void ListenAsync()
        {
            httpServer.Start();

            if (httpServer.IsListening)
                ZLog.Log($"WebMap: HTTP Server Listening on port {SERVER_PORT}");
            else
                ZLog.LogError("WebMap: HTTP Server Failed To Start !!!");
            // after Start: a broadcast before it throws, as every tick did until the server listened
            if (broadcastTimer == null)
                broadcastTimer = new System.Threading.Timer(_ => Tick(), null, TimeSpan.Zero, TimeSpan.FromSeconds(PLAYER_UPDATE_INTERVAL));
        }

        // Pool thread, every player_update_interval: the players and new chat to every open socket.
        private void Tick()
        {
            string dataString = "";
            if (forceReload)
            {
                webSocketHandler.Sessions.Broadcast("reload\n");
                forceReload = false;
            }
            else
            {
                dataString = playersWs;
                if (dataString != lastPlayerResponse)
                {
                    webSocketHandler.Sessions.Broadcast(dataString);
                    lastPlayerResponse = dataString;
                }

                List<string> tosend = null;
                lock (messageLock)
                {
                    if (newMessages.Count > 0)
                    {
                        tosend = new List<string>();
                        newMessages.ForEach(message =>
                        {
                            tosend.Add(message.ToJson());
                            sentMessages.Add(message);
                        });
                        newMessages.Clear();
                        newMessages.TrimExcess();
                        // Per kind, not over the whole list: a quiet evening of
                        // joins and deaths would otherwise push every line of
                        // chat out of a feed someone is reading for the chat.
                        TrimToDepth(sentMessages, 0, WebMapConfig.MAX_MESSAGES);
                        TrimToDepth(sentMessages, 1, WebMapConfig.MAX_MESSAGES);
                        var all = new List<string>(sentMessages.Count);
                        sentMessages.ForEach(m => all.Add(m.ToJson()));
                        messagesJson = "[" + string.Join(", ", all) + "]";
                    }
                }
                if (tosend != null && tosend.Count > 0)
                    webSocketHandler.Sessions.Broadcast("messages\n[" + string.Join(",", tosend) + "]");
            }
            // the players for Munin's map, every tick, stamped with the server's time: the page plays
            // them back smoothly from one to the next (munin/js/layers/players.js)
            webSocketHandler.Sessions.Broadcast(LiveFrame(playersLive, DateTimeOffset.UtcNow.ToUnixTimeMilliseconds(), worldWindDeg));
            // the tiles drawn again since the last tick, "z/x/y" each, for open maps to fetch anew
            string tiles = TilesFrame(Tiles.TileStore.DrainNotifications(), Tiles.TileStore.OnDisk, Tiles.TileStore.QueueLength);
            if (tiles != null) webSocketHandler.Sessions.Broadcast(tiles);
            // the markers changed (a sweep, a boat moved, a base renamed): open maps fetch them again
            int markersRev = Tiles.Markers.Rev;
            if (markersRev != sentMarkersRev) { sentMarkersRev = markersRev; webSocketHandler.Sessions.Broadcast(MarkersFrame(markersRev)); }
            // the Events panel's new lines, and the raid and invasions on now when they change
            string events = Feed.DrainPendingJson();
            if (events != null) webSocketHandler.Sessions.Broadcast("events\n" + events);
            string raid = WorldEvents.RaidJson;
            if (raid != sentRaid) { sentRaid = raid; webSocketHandler.Sessions.Broadcast("raid\n" + raid); }
            string inv = WorldEvents.InvasionsJson, invKey = InvasionKey(inv);   // ("left" counts down: the page counts itself)
            if (invKey != sentInvasions) { sentInvasions = invKey; webSocketHandler.Sessions.Broadcast("invasions\n" + inv); }
        }
        private string sentRaid = "null", sentInvasions = "[]";
        internal static string InvasionKey(string json) => System.Text.RegularExpressions.Regex.Replace(json, ",\"(left|age)\":[0-9.]+", "");
        private int sentMarkersRev = int.MinValue;

        // /data/hello.json: the raid and invasions on now and the Events panel's latest lines
        internal static string HelloJson(string raid, string invasions, string events) =>
            "{\"raid\":" + raid + ",\"invasions\":" + invasions + ",\"events\":" + events + "}";

        // markers\n<rev>: /data/markers.json has changed
        internal static string MarkersFrame(int rev) => "markers\n" + rev.ToString(CultureInfo.InvariantCulture);

        // live\n{"ts":<unix ms>,"players":[...]}: the players as Munin's map reads them
        // (windDeg: where the wind blows towards, 0 = north; left out below 0, unknown)
        internal static string LiveFrame(string players, long ts, int windDeg = -1) =>
            "live\n{\"ts\":" + ts.ToString(CultureInfo.InvariantCulture) + ",\"players\":" + players
            + (windDeg >= 0 ? ",\"windDeg\":" + windDeg.ToString(CultureInfo.InvariantCulture) : "") + "}";

        // tiles\n{"keys":["z/x/y",...],"status":"<on disk>/<queued>"}; null with nothing drawn
        internal static string TilesFrame(List<string> keys, int onDisk, int queued)
        {
            if (keys == null || keys.Count == 0) return null;
            var j = new Util.JsonWriter(keys.Count * 12 + 48);
            j.BeginObject().Key("keys").BeginArray();
            foreach (var k in keys) j.Value(k);
            j.End().Prop("status", onDisk + "/" + queued).End();
            return "tiles\n" + j;
        }

        public void BroadcastPing(long id, string name, Vector3 position)
        {
            webSocketHandler.Sessions.Broadcast($"ping\n{id}\n{name}\n{FixedValue(position.x)},{FixedValue(position.z)}");
            Feed.Add("ping", name, "pinged the map", position.x, position.z);
        }

        // Pins by the character name in each CSV line, for the player tallies.
        public Dictionary<string, int> PinsByName()
        {
            var d = new Dictionary<string, int>();
            lock (pins)
                foreach (string line in pins)
                {
                    var parts = line.Split(',');
                    if (parts.Length < 4) continue;
                    d.TryGetValue(parts[3], out int n);
                    d[parts[3]] = n + 1;
                }
            return d;
        }

        public void AddPin(string id, string pinId, string type, string name, Vector3 position, string pinText)
        {
            lock (pins) pins.Add($"{id},{pinId},{type},{name},{FixedValue(position.x)},{FixedValue(position.z)},{pinText}");
            webSocketHandler.Sessions.Broadcast(
                $"pin\n{id}\n{pinId}\n{type}\n{name}\n{FixedValue(position.x)},{FixedValue(position.z)}\n{pinText}");
            Feed.Add("pin", name, "placed a pin" + (string.IsNullOrEmpty(pinText) ? "" : ": " + pinText), position.x, position.z);
        }

        public void RemovePin(int idx)
        {
            string[] pinParts;
            lock (pins)
            {
                pinParts = pins[idx].Split(',');
                pins.RemoveAt(idx);
            }
            webSocketHandler.Sessions.Broadcast($"rmpin\n{pinParts[1]}");
        }

        // Newest first, keep `max` of this kind, drop the rest. Caller holds messageLock.
        private static void TrimToDepth(List<MapMessage> list, int ev, int max)
        {
            int n = 0;
            for (int i = list.Count - 1; i >= 0; i--)
            {
                if (list[i].ev != ev) continue;
                if (++n > max) { list.RemoveAt(i); n--; }
            }
        }

        public void AddMessage(long id, int type, string name, string message, bool ev = false)
        {
            lock (messageLock) newMessages.Add(new MapMessage(id, type, name, message, ev));
            try { Feed.FromMessage(type, name, message, ev); } catch (Exception e) { ZLog.LogWarning("WebMap: feed: " + e.Message); }
        }

        private static string FixedValue(float f)
        {
            return f.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
