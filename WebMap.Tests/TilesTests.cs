using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using WebMap.Tiles;
using Xunit;

namespace WebMap.Tests
{
    // Munin's map tiles, as ForgeMap serves them.
    public class TilesTests
    {
        // A tile key that means another square of ground puts the world in the wrong place on the page.
        [Theory]
        [InlineData(0f, 0f)]
        [InlineData(-10751f, 10751f)]
        [InlineData(1234.5f, -6789.25f)]
        public void APointLiesInsideTheTileItMapsToAtEveryZoom(float x, float z)
        {
            for (int zoom = 0; zoom <= TileMath.MAX_ZOOM; zoom++)
            {
                TileMath.WorldToTile(zoom, x, z, out int tx, out int ty);
                Assert.True(TileMath.Valid(zoom, tx, ty));
                TileMath.TileBounds(zoom, tx, ty, out float minX, out float minZ, out float maxX, out float maxZ);
                Assert.InRange(x, minX, maxX);
                Assert.InRange(z, minZ, maxZ);
            }
            Assert.Equal(256f, TileMath.TileSpanMeters(TileMath.MAX_ZOOM));   // zoom 7: a metre a pixel
            Assert.Equal(84, TileMath.TilesPerSide(TileMath.MAX_ZOOM));
            TileMath.Unkey(TileMath.Key(6, 41, 17), out int kz, out int kx, out int ky);
            Assert.Equal((6, 41, 17), (kz, kx, ky));
        }

        // Spoilers: a close-zoom tile, or a chunk of trees, over ground nobody has walked is never made.
        [Fact]
        public void OnlyABoxWithWalkedGroundInItCountsAsExplored()
        {
            int size = WebMapConfig.TEXTURE_SIZE, half = size / 2;
            var fog = new byte[size * size * 4];
            int p = (int)Math.Round(1000f / WebMapConfig.PIXEL_SIZE + half);      // one walked pixel at (1000, 1000)
            fog[(p * size + p) * 4] = 255;
            Assert.True(MapFog.AnyExplored(fog, 900f, 900f, 1100f, 1100f));
            Assert.False(MapFog.AnyExplored(fog, 1100f, 900f, 1300f, 1100f));
            Assert.False(MapFog.AnyExplored(fog, -1100f, -1100f, -900f, -900f));   // the other side of the world
            Assert.False(MapFog.AnyExplored(null, -20000f, -20000f, 20000f, 20000f)); // before the fog loads: nothing
        }

        // The tile route takes its path apart: anything but a tile of a known layer is no tile.
        [Fact]
        public void OnlyATilePathOfAKnownLayerIsATile()
        {
            Assert.True(MapDataServer.ParseTile("/tiles/map/5/12/34.png", out string layer, out int z, out int x, out int y));
            Assert.Equal(("map", 5, 12, 34), (layer, z, x, y));
            Assert.True(MapDataServer.ParseTile("/tiles/height/7/0/0.png", out _, out _, out _, out _));
            Assert.False(MapDataServer.ParseTile("/tiles/fog/5/1/1.png", out _, out _, out _, out _));
            Assert.False(MapDataServer.ParseTile("/tiles/map/5/-1/1.png", out _, out _, out _, out _));
            Assert.False(MapDataServer.ParseTile("/tiles/map/5/1/1.webp", out _, out _, out _, out _));
            Assert.False(MapDataServer.ParseTile("/tiles/map/../1/1.png", out _, out _, out _, out _));
            Assert.False(MapDataServer.ParseTile("/tiles/map/5/1.png", out _, out _, out _, out _));
        }

        // Open maps fetch again exactly the tiles drawn again, and hear nothing when none were.
        [Fact]
        public void TheTilesFrameListsTheTilesDrawnAgainAndIsNothingWithoutThem()
        {
            Assert.Null(MapDataServer.TilesFrame(null, 10, 0));
            Assert.Null(MapDataServer.TilesFrame(new List<string>(), 10, 0));
            Assert.Equal("tiles\n{\"keys\":[\"5/12/34\",\"6/24/68\"],\"status\":\"40/3\"}",
                         MapDataServer.TilesFrame(new List<string> { "5/12/34", "6/24/68" }, 40, 3));
        }

        // A painted road or field with no digging is still changed ground: the map shows it.
        [Fact]
        public void ATerraformBlobWithPaintAloneIsAPatchAndOneWithNothingIsNone()
        {
            byte[] Blob(bool paint)
            {
                var ms = new MemoryStream();
                using (var gz = new GZipStream(ms, CompressionMode.Compress, true))
                using (var w = new BinaryWriter(gz))
                {
                    w.Write(1); w.Write(2); w.Write(0f); w.Write(0f); w.Write(0f); w.Write(4f);
                    w.Write(TerrainPatches.N);
                    for (int i = 0; i < TerrainPatches.N; i++) w.Write(false);
                    w.Write(TerrainPatches.N);
                    for (int i = 0; i < TerrainPatches.N; i++)
                    {
                        if (paint && i == 300) { w.Write(true); w.Write(0f); w.Write(1f); w.Write(0f); w.Write(1f); }   // cultivated
                        else w.Write(false);
                    }
                }
                return ms.ToArray();
            }
            var p = TerrainPatches.Decode(Blob(true));
            Assert.NotNull(p);
            Assert.True(p.anyPaint);
            Assert.False(p.anyHeight);
            Assert.Equal(new byte[] { 0, 255, 0 }, new[] { p.paint[900], p.paint[901], p.paint[902] });
            Assert.Null(TerrainPatches.Decode(Blob(false)));
        }
    }
}
