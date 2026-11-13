using System.IO;
using System.Text.Json;
using Xunit;

namespace WebMap.Tests
{
    // The map's Events panel (Feed) and the world's events (WorldEvents): ticket fonctions-munin-hors-carte.
    public class FeedTests : WithDir
    {
        public FeedTests() { Feed.ResetForTests(Dir); }

        private static JsonElement[] Drain()
        {
            string j = Feed.DrainPendingJson();
            return j == null ? new JsonElement[0] : JsonSerializer.Deserialize<JsonElement[]>(j);
        }

        // ForgeMap's own feed lines must read as the panel's kinds, or its filters sort nothing.
        [Fact]
        public void ForgeMapsFeedLinesBecomeThePanelsKinds()
        {
            Feed.FromMessage(1, "Server", "player _Withers_ joined", true);
            Feed.FromMessage(1, "Server", "player _Withers_ left", true);
            Feed.FromMessage(1, "Server", "player _Grant_ died", true);
            Feed.FromMessage(2, "Withers", "Hello all", false);
            Feed.FromMessage(1, "Grant", "hi", false);
            Feed.FromMessage(2, WebMapConfig.ANNOUNCE_NAME, "Restart at nine", false);
            var e = Drain();
            Assert.Equal(new[] { "join", "leave", "death", "shout", "chat", "server" }, System.Array.ConvertAll(e, x => x.GetProperty("type").GetString()));
            Assert.Equal("Withers", e[0].GetProperty("name").GetString());
            Assert.Equal("joined the server", e[0].GetProperty("text").GetString());
            Assert.Equal("Grant", e[2].GetProperty("name").GetString());
            Assert.Null(Feed.DrainPendingJson());
        }

        // "Show older" reads the log back from before the oldest line shown, oldest first; a restart
        // starts the panel from the log's end.
        [Fact]
        public void TheHistoryOutlivesARestartAndPagesBackwards()
        {
            for (int i = 0; i < 5; i++) Feed.Add("chat", "W", "line " + i, 10f * i, 0f);
            Assert.True(File.Exists(Path.Combine(Dir, "events.jsonl")));
            var all = JsonSerializer.Deserialize<JsonElement[]>(Feed.RecentJson);
            Assert.Equal(5, all.Length);
            Assert.Equal(40, all[4].GetProperty("x").GetDouble());
            string before = all[3].GetProperty("ts").GetString();
            var older = JsonSerializer.Deserialize<JsonElement[]>(Feed.OlderJson(before, 2));
            Assert.True(older.Length >= 1 && older.Length <= 2);
            Assert.All(older, o => Assert.True(string.CompareOrdinal(o.GetProperty("ts").GetString(), before) < 0));

            Feed.Load(Dir);
            var back = JsonSerializer.Deserialize<JsonElement[]>(Feed.RecentJson);
            Assert.Equal(5, back.Length);
            Assert.Equal("line 4", back[4].GetProperty("text").GetString());
        }

        [Fact]
        public void HelloCarriesTheRaidTheInvasionsAndTheLatestLines()
        {
            var h = JsonDocument.Parse(MapDataServer.HelloJson("null", "[]", "[{\"ts\":\"t\"}]")).RootElement;
            Assert.Equal(JsonValueKind.Null, h.GetProperty("raid").ValueKind);
            Assert.Equal(1, h.GetProperty("events").GetArrayLength());
        }

        // Every kill sets the key again: a rare creature's must not read as a boss down.
        [Theory]
        [InlineData("defeated_eikthyr", "defeated_eikthyr")]
        [InlineData("Defeated_GDKing 1", "defeated_gdking")]
        [InlineData("defeated_writhan", null)]
        [InlineData("KilledTroll", null)]
        [InlineData("defeated_", null)]
        public void OnlyABossesKeyIsABossDown(string raw, string key) => Assert.Equal(key, WorldEvents.BossKey(raw));

        [Fact]
        public void BossesAndPeopleReadAsWords()
        {
            Assert.Equal("The Elder", WorldEvents.BossName("defeated_gdking"));
            Assert.Equal("Newboss", WorldEvents.BossName("defeated_newboss"));
            Assert.Equal("A, B and C", WorldEvents.Names(new System.Collections.Generic.List<string> { "A", "B", "C" }));
            Assert.Equal("", WorldEvents.Names(new System.Collections.Generic.List<string>()));
        }

        // The time left counts down each tick: only a change in the set itself is sent again.
        [Fact]
        public void AnInvasionCountingDownIsNoNewFrame() =>
            Assert.Equal(MapDataServer.InvasionKey("[{\"id\":1,\"left\":30,\"age\":5}]"), MapDataServer.InvasionKey("[{\"id\":1,\"left\":28,\"age\":7}]"));
    }
}
