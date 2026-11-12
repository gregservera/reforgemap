using System;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Sockets;
using System.Text;
using BepInEx.Configuration;
using Xunit;
using Mod = WebMap.WebMap;

namespace WebMap.Tests
{
    // The write routes over real HTTP, on a loopback port: who may write, and as whom.
    // Configured as an operator does it: the BepInEx config, and announce.token beside the DLL.
    public class GateTests : WithDir
    {
        const string Token = "proxy-secret", Pin = "{\"op\":\"add\",\"x\":1,\"z\":2}";
        readonly string tokenFile = Path.Combine(AppContext.BaseDirectory, "announce.token");
        readonly (int port, string guild, string url, string key) was =
            (WebMapConfig.SERVER_PORT, WebMapConfig.DISCORD_GUILD, WebMapConfig.PUBLIC_URL, WebMapConfig.AUTH_PUBLIC_KEY);
        readonly MapDataServer server;
        readonly HttpClient http = new HttpClient();

        public GateTests()
        {
            var l = new TcpListener(IPAddress.Loopback, 0);
            l.Start(); int port = ((IPEndPoint)l.LocalEndpoint).Port; l.Stop();
            string cfg = Path.Combine(Dir, "webmap.cfg");
            File.WriteAllText(cfg, $"[Server]\nserver_port = {port}\ndiscord_guild = {AuthTests.Guild}\npublic_url = {AuthTests.Map}\n"
                                 + $"auth_public_key = {AuthTests.KeyOf(AuthTests.Service)}\n");
            WebMapConfig.ReadConfigFile(new ConfigFile(cfg, false));
            File.WriteAllText(tokenFile, Token);
            Settings.ResetForTests(Dir);
            Mod.worldDataPath = Dir;
            Mod.mapDataServer = server = new MapDataServer(IPAddress.Loopback);
            server.ListenAsync();
            http.BaseAddress = new Uri($"http://127.0.0.1:{port}");
        }

        public override void Dispose()
        {
            server.Stop();
            File.Delete(tokenFile);
            (WebMapConfig.SERVER_PORT, WebMapConfig.DISCORD_GUILD, WebMapConfig.PUBLIC_URL, WebMapConfig.AUTH_PUBLIC_KEY) = was;
            Mod.mapDataServer = null; Mod.worldDataPath = null;
            base.Dispose();
        }

        int Send(HttpMethod method, string path, string body, params (string, string)[] headers)
        {
            var req = new HttpRequestMessage(method, path);
            if (body != null) req.Content = new StringContent(body, Encoding.UTF8);
            foreach (var (k, v) in headers) req.Headers.TryAddWithoutValidation(k, v);
            return (int)http.Send(req).StatusCode;
        }
        int Post(string path, string body, params (string, string)[] h) => Send(HttpMethod.Post, path, body, h);
        int Get(string path, params (string, string)[] h) => Send(HttpMethod.Get, path, null, h);
        static (string, string) Bearer(bool owner = false, string guild = AuthTests.Guild, string aud = AuthTests.Map) =>
            ("Authorization", "Bearer " + AuthTests.Sign(AuthTests.Service, AuthTests.Body(owner, guild, aud)));
        string Owner() => server.pins.Last().Split(',')[3];

        [Fact]
        public void AWriteWithNoCredentialsIsRefused()
        {
            Assert.Equal(403, Post("/pins", Pin));
            Assert.Equal(403, Post("/names", "{\"id\":\"x\",\"name\":\"y\"}"));
            Assert.Equal(403, Post("/announce", "restart in 5"));
            Assert.Equal(403, Get("/settings"));
            Assert.Empty(server.pins);
        }

        // Drawing the map again costs minutes of CPU: an admin's action, never a visitor's.
        [Fact]
        public void OnlyAnAdminMayHaveTheMapDrawnAgain()
        {
            Assert.Equal(403, Post("/api/rerender?zoom=5", "{}"));
            Assert.Equal(403, Post("/api/rerender?zoom=5", "{}", Bearer()));
            Assert.Equal(403, Post("/api/rerender?zoom=5", "{}", ("X-Announce-Token", Token)));
            Assert.Equal(202, Post("/api/rerender?zoom=5", "{}", ("X-Announce-Token", Token), ("X-Admin", "1")));
            Assert.Equal(202, Post("/api/rerender?zoom=5", "{}", Bearer(owner: true)));
            Assert.Equal(400, Post("/api/rerender?zoom=9", "{}", Bearer(owner: true)));
        }

        // A tile not drawn yet is a pending 404 the page waits out; a path that is no tile is nothing.
        [Fact]
        public void ATileNotDrawnYetIsPendingAndAPathThatIsNoTileIsNotFound()
        {
            var r = http.Send(new HttpRequestMessage(HttpMethod.Get, "/tiles/map/0/0/0.png"));
            Assert.Equal(HttpStatusCode.NotFound, r.StatusCode);
            Assert.Equal("pending", string.Join(",", r.Headers.GetValues("X-Munin-Tile")));
            Assert.Equal(404, Get("/tiles/fog/0/0/0.png"));
            Assert.Equal(200, Get("/api/status"));
        }

        // Munin's page reads its map data at these paths: a chunk nobody built on is an empty chunk,
        // and anything else it may ask for that is not served yet is a 404 it shrugs off.
        [Fact]
        public void MuninsDataPathsAnswerAndAPathThatIsNoDataIsNotFound()
        {
            var r = http.Send(new HttpRequestMessage(HttpMethod.Get, "/data/structures/10_10.json"));
            Assert.Equal(HttpStatusCode.OK, r.StatusCode);
            Assert.Contains("\"pieces\":[]", r.Content.ReadAsStringAsync().Result);
            Assert.Equal(404, Get("/data/ruins/10_10.json"));          // no ruin there: nothing to draw
            Assert.Equal(404, Get("/data/structures/99_10.json"));     // off the grid
            Assert.Equal(404, Get("/data/markers.json"));
            Assert.Equal(404, Get("/data/veg/1_2_3.bin"));
            Assert.Equal(503, Get("/data/fog.png"));                    // no fog yet: never an empty 200
        }

        // Munin's 3D view reads ForgeMap's objects in its own chunk numbering: a chunk nobody walked
        // sends nothing, and the index lists none of them.
        [Fact]
        public void MuninsThreeDPathsServeForgeMapsObjectsAndNothingUnwalked()
        {
            Assert.Equal(42, MapDataServer.MuninChunkShift);           // 10752 m from the corner to the middle
            var r = http.Send(new HttpRequestMessage(HttpMethod.Get, "/data/objects/index.json"));
            Assert.Equal(HttpStatusCode.OK, r.StatusCode);
            Assert.Contains("\"chunks\":[]", r.Content.ReadAsStringAsync().Result);
            Assert.Equal(404, Get("/data/objects/42_42.bin"));          // the world's middle, unwalked
            Assert.Equal(200, Get("/data/prefabs.json"));
        }

        // Munin's page reads the pins as JSON, the same ones /pins writes; whose they are is the member's name.
        [Fact]
        public void APinWrittenThroughPinsShowsInMuninsPinList()
        {
            server.pins.Add("web,w1,fire,Rurik,10.5,-20,Camp, by the lake");
            var j = J.Parse(server.PinsMuninJson()).EnumerateArray().Single();
            Assert.Equal("w1", j.Str("id"));
            Assert.Equal("fire", j.Str("type"));
            Assert.Equal("Rurik", j.Str("name"));
            Assert.Equal("Camp, by the lake", j.Str("text"));
            Assert.Equal(200, Get("/data/pins.json"));
        }

        [Fact]
        public void TheProxysTokenWritesAsTheUserItNames()
        {
            Assert.Equal(200, Post("/pins", Pin, ("X-Announce-Token", Token), ("X-User", "Gonk%20the%20B%C3%B8ld")));
            Assert.Equal("Gonk the Bøld", Owner());
            Assert.Equal(403, Get("/settings", ("X-Announce-Token", Token)));
            Assert.Equal(200, Get("/settings", ("X-Announce-Token", Token), ("X-Admin", "1")));
            Assert.Equal(202, Post("/announce", "restart in 5", ("X-Announce-Token", Token)));
        }

        [Fact]
        public void XUserAndXAdminWithoutTheTokenAreIgnored()
        {
            Assert.Equal(403, Post("/pins", Pin, ("X-User", "Mallory"), ("X-Admin", "1")));
            Assert.Equal(403, Post("/pins", Pin, ("X-Announce-Token", "proxy-secreT"), ("X-User", "Mallory")));
            Assert.Equal(200, Post("/pins", Pin, Bearer(), ("X-User", "Mallory")));
            Assert.Equal("Rurik \"the Red\"", Owner());
            Assert.Equal(403, Get("/settings", Bearer(), ("X-Admin", "1")));
        }

        [Fact]
        public void ASessionWritesAsAMemberAndReachesTheSettingsOnlyAsAnAdmin()
        {
            Assert.Equal(200, Post("/pins", Pin, Bearer()));
            Assert.Equal(403, Get("/settings", Bearer()));
            Assert.Equal(200, Get("/settings", Bearer(owner: true)));
            Assert.Equal(403, Post("/announce", "restart in 5", Bearer(owner: true)));     // the proxy's token alone
        }

        [Fact]
        public void ASessionForAnotherDiscordServerOrAnotherMapIsRefusedAtTheRoute()
        {
            Assert.Equal(403, Post("/pins", Pin, Bearer(guild: "1400000000000000002")));
            Assert.Equal(403, Post("/pins", Pin, Bearer(aud: "http://203.0.113.9:3000")));
            Assert.Equal(403, Get("/settings", Bearer(owner: true, aud: "http://203.0.113.9:3000")));
            Assert.Empty(server.pins);
        }
    }
}
