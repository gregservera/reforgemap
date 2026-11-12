using System;
using UnityEngine;

namespace WebMap
{
    // Whether anyone has been somewhere yet.
    //
    // The structures layer is drawn under the fog mask by the page, so builds in
    // unexplored land are hidden for free. Markers cannot be masked that way, so
    // anything drawn as a marker is filtered through this instead -- not reported
    // at all, rather than merely not drawn.
    internal static class MapFog
    {
        public static bool Explored(float x, float z)
        {
            try
            {
                var fog = WebMap.mapDataServer != null ? WebMap.mapDataServer.fogRgba : null;
                if (fog == null) return true;          // before the fog loads, hide nothing
                int size = WebMapConfig.TEXTURE_SIZE, half = size / 2;
                int px = Mathf.RoundToInt(x / WebMapConfig.PIXEL_SIZE + half);
                int py = Mathf.RoundToInt(z / WebMapConfig.PIXEL_SIZE + half);
                if (px < 0 || py < 0 || px >= size || py >= size) return false;
                return fog[(py * size + px) * 4] > 127;   // white is explored
            }
            catch { return true; }
        }

        // Any walked ground in a box of world metres (the tile store and the tree regions, from their
        // own threads: the fog is only ever read here). Before the fog loads, nothing is walked: the
        // close-zoom tiles wait for it rather than render the whole world.
        public static bool AnyExplored(float minX, float minZ, float maxX, float maxZ) =>
            AnyExplored(WebMap.mapDataServer != null ? WebMap.mapDataServer.fogRgba : null, minX, minZ, maxX, maxZ);

        internal static bool AnyExplored(byte[] fog, float minX, float minZ, float maxX, float maxZ)
        {
            if (fog == null) return false;
            int size = WebMapConfig.TEXTURE_SIZE, half = size / 2;
            float ps = WebMapConfig.PIXEL_SIZE;
            int x0 = Math.Max(0, Mathf.FloorToInt(minX / ps + half)), x1 = Math.Min(size - 1, Mathf.CeilToInt(maxX / ps + half));
            int y0 = Math.Max(0, Mathf.FloorToInt(minZ / ps + half)), y1 = Math.Min(size - 1, Mathf.CeilToInt(maxZ / ps + half));
            for (int y = y0; y <= y1; y++)
                for (int x = x0; x <= x1; x++)
                    if (fog[(y * size + x) * 4] > 127) return true;
            return false;
        }

        // Every walked fog pixel, every `stride` pixels each way, as world metres (the map tiles
        // queue what is missing over walked ground at start)
        public static void ForEachExplored(Action<float, float> at, int stride)
        {
            var fog = WebMap.mapDataServer != null ? WebMap.mapDataServer.fogRgba : null;
            if (fog == null) return;
            int size = WebMapConfig.TEXTURE_SIZE, half = size / 2;
            float ps = WebMapConfig.PIXEL_SIZE;
            stride = Math.Max(1, stride);
            for (int y = 0; y < size; y += stride)
                for (int x = 0; x < size; x += stride)
                    if (fog[(y * size + x) * 4] > 127) at((x - half) * ps, (y - half) * ps);
        }

        // moves each time the fog lifts somewhere: a cache key for what is built from it
        public static int Revision => WebMap.mapDataServer != null ? WebMap.mapDataServer.fogRev : 0;

        // The 3D view's data comes in 256 m chunks (WorldObjects.ChunkOf), and a chunk
        // with any walked ground in it is a walked chunk. Built from the whole fog when
        // it loads and marked pixel by pixel as it lifts, both on the game thread; a
        // flag only ever turns on, so any thread may read it. Before the fog loads
        // every chunk is unwalked: the 3D data holds nothing back by default.
        private const int Span = 128, Origin = 64;       // chunks -64..63 each way, the whole world
        private static volatile bool[] chunks;

        public static bool ChunkExplored(int cx, int cz)
        {
            var c = chunks;
            cx += Origin; cz += Origin;
            return c != null && cx >= 0 && cz >= 0 && cx < Span && cz < Span && c[cz * Span + cx];
        }

        public static void RebuildChunks(byte[] fog)
        {
            var c = new bool[Span * Span];
            int size = WebMapConfig.TEXTURE_SIZE;
            if (fog != null)
                for (int py = 0; py < size; py++)
                    for (int px = 0; px < size; px++)
                        if (fog[(py * size + px) * 4] > 127) Mark(c, px, py);
            chunks = c;
        }

        public static void MarkPixel(int px, int py)
        {
            var c = chunks;
            if (c != null) Mark(c, px, py);
        }

        // a fog pixel is PIXEL_SIZE across, centred where Explored rounds to; one on a
        // chunk's edge marks both sides
        private static void Mark(bool[] c, int px, int py)
        {
            int half = WebMapConfig.TEXTURE_SIZE / 2;
            float ps = WebMapConfig.PIXEL_SIZE, x = (px - half) * ps, z = (py - half) * ps, r = ps / 2f;
            int x0 = WorldObjects.ChunkOf(x - r) + Origin, x1 = WorldObjects.ChunkOf(x + r) + Origin;
            int z0 = WorldObjects.ChunkOf(z - r) + Origin, z1 = WorldObjects.ChunkOf(z + r) + Origin;
            for (int cz = z0; cz <= z1; cz++)
                for (int cx = x0; cx <= x1; cx++)
                    if (cx >= 0 && cz >= 0 && cx < Span && cz < Span) c[cz * Span + cx] = true;
        }
    }
}
