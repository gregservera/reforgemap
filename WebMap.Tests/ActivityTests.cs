using System.Collections.Generic;
using System.Text.Json;
using Xunit;

namespace WebMap.Tests
{
    // The map's Activity layers (Activity, from Munin): trails, time spent and deaths per 64 m zone.
    public class ActivityTests : WithDir
    {
        public ActivityTests() { Activity.Load(Dir); }

        private static Activity.Snap P(string name, float x, float z, bool shown = true) =>
            new Activity.Snap { key = name, name = name, x = x, z = z, hasPos = shown };

        // A hidden player must not leave a trail the page can follow.
        [Fact]
        public void OnlyPlayersWhoShowOnTheMapLeaveATrail()
        {
            Activity.Sample(new List<Activity.Snap> { P("Seen", 0, 0), P("Hidden", 100, 100, false) });
            Activity.Sample(new List<Activity.Snap> { P("Seen", 50, 10), P("Hidden", 150, 100, false) });
            var d = JsonDocument.Parse(Activity.Json(3)).RootElement;
            var trails = d.GetProperty("trails");
            Assert.Equal(1, trails.GetArrayLength());
            Assert.Equal("Seen", trails[0].GetProperty("name").GetString());
            Assert.Equal(2, trails[0].GetProperty("pts").GetArrayLength());
            Assert.Equal(64, d.GetProperty("cell").GetInt32());
        }

        // Deaths and time count per zone, and come back after a restart.
        [Fact]
        public void ZonesKeepTheirDeathsAndTimeOverARestart()
        {
            Activity.Sample(new List<Activity.Snap> { P("W", 10, 10) });
            Activity.OnDeath(10, 10);
            Activity.OnDeath(20, -20);
            Activity.Save();
            Activity.Load(Dir);
            var z = JsonDocument.Parse(Activity.ZoneJson(0, 0)).RootElement;
            Assert.Equal(2, z.GetProperty("deaths").GetInt32());
            Assert.True(z.GetProperty("seconds").GetInt32() > 0);
            Assert.Equal("W", z.GetProperty("players")[0][0].GetString());
        }
    }
}
