using System.Collections.Generic;
using System.Text.Json;
using WebMap.Tiles;
using Xunit;

namespace WebMap.Tests
{
    // The Activity menu's New building and Lag hotspots (Hotspots, BuildHistory: from Munin).
    public class HotspotsTests : WithDir
    {
        private static long Z(int zx, int zz) => ((long)zx << 32) ^ (uint)zz;

        // A base that grew shows with what it had then; one taken down shows at 0; a few pieces moved do not.
        [Fact]
        public void NewBuildingIsWhatChangedSinceThen()
        {
            BuildHistory.Load(Dir);
            Assert.Contains("\"pending\":true", BuildHistory.Json(1));
            BuildHistory.Record(new Dictionary<long, int[]> { [Z(1, 2)] = new[] { 40, 0, 0, 0 }, [Z(-3, 4)] = new[] { 20, 0, 0, 0 }, [Z(5, 5)] = new[] { 10, 0, 0, 0 } });
            BuildHistory.Record(new Dictionary<long, int[]> { [Z(1, 2)] = new[] { 90, 0, 0, 0 }, [Z(5, 5)] = new[] { 11, 0, 0, 0 } });
            var zones = JsonDocument.Parse(BuildHistory.Json(1)).RootElement.GetProperty("zones");
            var got = new List<string>();
            foreach (var z in zones.EnumerateArray()) got.Add($"{z[0]},{z[1]}:{z[2]}<-{z[3]}");
            got.Sort();
            Assert.Equal(new[] { "-3,4:0<-20", "1,2:90<-40" }, got);
        }

        // A light or a creature weighs on a player's computer about as much as a dozen pieces.
        [Fact]
        public void LightsAndCreaturesWeighMoreThanPieces() =>
            Assert.True(Hotspots.Score(new[] { 0, 1, 0, 0 }) > Hotspots.Score(new[] { 12, 0, 0, 0 }) && Hotspots.Score(new[] { 0, 0, 1, 0 }) >= 12);
    }
}
