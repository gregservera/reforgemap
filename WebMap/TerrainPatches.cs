// Ported from f00d4tehg0dz/valheim-webmap (MIT); the paint grid and the renderer's reads
// (DeltaAt, PaintAt, AnyIn) from Munin Map 3.3.1 (cocopuff2u-gaming/munin-map, 8c376b2), MIT.
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using WebMap.Tiles;

namespace WebMap
{
    // Player terraforming, decoded from the world.
    //
    // Every zone a player has dug, raised, levelled or paved in owns a
    // "_TerrainCompiler" object whose ZDO carries the modifications as a
    // gzipped blob (ZDOVars.s_TCData): for each of the 65x65 heightmap vertices
    // a flag and two height deltas (level + smooth), then for each vertex a flag
    // and an RGBA paint (r dirt, g cultivated, b paved). The game's Heightmap
    // adds the deltas to the generator's height, held within 8 m of it
    // (TerrainComp.ApplyToHeightmap), and so do Heights and the map tiles:
    // roads, moats and flattened bases stand in the 3D view and show on the map
    // as they are in the world.
    //
    // Observe is the sweep's, on the game thread, and decodes a blob only when
    // its data revision has moved. Patches are immutable arrays in a concurrent
    // map, so the height endpoint and the tile renderer read them from any thread.
    internal static class TerrainPatches
    {
        public const int W = 65;                  // vertices per zone edge
        public const int N = W * W;
        public const int ZoneSize = 64;
        public static readonly int CompilerHash = "_TerrainCompiler".GetStableHashCode();

        public sealed class Patch
        {
            public float[] delta;                 // N entries, level + smooth clamped to +-8 m; row z, column x
            public byte[] paint;                  // N*3 entries r,g,b 0..255, or null when nothing is painted
            public bool anyHeight, anyPaint;
            public int hash;                      // content hash: which tiles and chunks moved
        }

        private static readonly ConcurrentDictionary<long, Patch> patches = new ConcurrentDictionary<long, Patch>();
        // zone -> data revision last decoded, so an unchanged zone costs one lookup a sweep;
        // the walk and its finish never overlap, so no lock
        private static readonly Dictionary<long, uint> seenRev = new Dictionary<long, uint>();
        private static HashSet<long> seen;
        private static readonly HashSet<long> changedZones = new HashSet<long>();

        public static volatile int Rev;           // bumped when any zone's heights changed
        public static int Count => patches.Count;

        // Zone (zx, zz) covers x in [zx*64-32, zx*64+32); its vertex (i, j) stands at
        // (zx*64-32+i, zz*64-32+j). The same keys as TileMath's.
        public static int ZoneOf(float w) => (int)Math.Floor((w + ZoneSize / 2f) / ZoneSize);
        public static long ZoneKey(int zx, int zz) => ((long)(zx + 32768) << 20) | (uint)(zz + 32768);

        public static Patch Get(int zx, int zz) { patches.TryGetValue(ZoneKey(zx, zz), out var p); return p; }

        public static ICollection<long> Zones() => patches.Keys;

        // Game thread, before the walk.
        public static void Begin() { seen = new HashSet<long>(); changedZones.Clear(); }

        // Game thread, for each terrain compiler the walk meets.
        public static void Observe(ZDO zdo, UnityEngine.Vector3 pos)
        {
            if (seen == null) return;
            int zx = ZoneOf(pos.x), zz = ZoneOf(pos.z);
            long key = ZoneKey(zx, zz);
            seen.Add(key);
            uint rev = 0;
            try { rev = unchecked((uint)zdo.DataRevision); } catch { }
            if (seenRev.TryGetValue(key, out uint prev) && prev == rev) return;
            seenRev[key] = rev;

            byte[] blob = null;
            try { blob = zdo.GetByteArray(ZDOVars.s_TCData); } catch { }
            Patch p = null;
            if (blob != null && blob.Length > 0)
            {
                try { p = Decode(blob); }
                catch (Exception e) { if (WebMapConfig.DEBUG) ZLog.LogWarning($"WebMap: terrain blob for zone {zx},{zz} not understood: {e.Message}"); return; }
            }
            bool had = patches.TryGetValue(key, out var old);
            if (p == null) { if (had) { patches.TryRemove(key, out _); changedZones.Add(key); } return; }
            if (had && old.hash == p.hash) return;
            patches[key] = p;
            changedZones.Add(key);
        }

        // The sweep's pool thread: a zone whose compiler is gone is flat again. The zones whose
        // ground changed this sweep go into `changed`, for the tiles over them.
        public static void Finish(HashSet<long> changed)
        {
            var s = seen;
            seen = null;
            if (s == null) return;
            foreach (long key in new List<long>(patches.Keys))
                if (!s.Contains(key)) { patches.TryRemove(key, out _); changedZones.Add(key); }
            foreach (long key in new List<long>(seenRev.Keys)) if (!s.Contains(key)) seenRev.Remove(key);
            if (changedZones.Count > 0 || Rev == 0) Rev++;
            if (changed != null) changed.UnionWith(changedZones);
        }

        // TerrainComp's own layout; a blob that changes neither height nor paint is null.
        public static Patch Decode(byte[] blob)
        {
            byte[] raw = Gunzip(blob);
            var p = new Patch { delta = new float[N] };
            int hash = 17;
            using (var br = new BinaryReader(new MemoryStream(raw)))
            {
                br.ReadInt32();                     // version
                br.ReadInt32();                     // operations
                br.ReadSingle(); br.ReadSingle(); br.ReadSingle();   // last op point
                br.ReadSingle();                    // last op radius
                int n = br.ReadInt32();
                if (n != N) throw new FormatException("height grid is " + n + " vertices, expected " + N);
                for (int i = 0; i < n; i++)
                {
                    if (!br.ReadBoolean()) continue;
                    float d = br.ReadSingle() + br.ReadSingle();       // level + smooth
                    d = d < -8f ? -8f : d > 8f ? 8f : d;
                    p.delta[i] = d;
                    if (d != 0f) { p.anyHeight = true; hash = unchecked(hash * 31 + i); hash = unchecked(hash * 31 + (int)(d * 100f)); }
                }
                // the paint grid; a blob from before the game wrote one simply ends here
                if (br.BaseStream.Position + 4 <= br.BaseStream.Length)
                {
                    int m = br.ReadInt32();
                    if (m != N && m != 0) throw new FormatException("paint grid is " + m + " vertices, expected " + N);
                    for (int i = 0; i < m; i++)
                    {
                        if (!br.ReadBoolean()) continue;
                        float r = br.ReadSingle(), g = br.ReadSingle(), b = br.ReadSingle();
                        br.ReadSingle();            // a
                        if (r <= 0.01f && g <= 0.01f && b <= 0.01f) continue;
                        if (p.paint == null) p.paint = new byte[N * 3];
                        p.paint[i * 3] = (byte)(Clamp01(r) * 255f);
                        p.paint[i * 3 + 1] = (byte)(Clamp01(g) * 255f);
                        p.paint[i * 3 + 2] = (byte)(Clamp01(b) * 255f);
                        p.anyPaint = true;
                        hash = unchecked(hash * 31 + i); hash = unchecked(hash * 31 + p.paint[i * 3] + p.paint[i * 3 + 1] * 7 + p.paint[i * 3 + 2] * 13);
                    }
                }
            }
            p.hash = hash;
            return p.anyHeight || p.anyPaint ? p : null;
        }

        private static float Clamp01(float v) => v < 0 ? 0 : v > 1 ? 1 : v;

        private static byte[] Gunzip(byte[] data)
        {
            using (var ms = new MemoryStream(data))
            using (var gz = new GZipStream(ms, CompressionMode.Decompress))
            using (var outp = new MemoryStream())
            {
                gz.CopyTo(outp);
                return outp.ToArray();
            }
        }

        // ---- the tile renderer's reads (any thread)

        // Bilinear height delta at a world position, the ground the game shapes round its
        // locations (LocationTerrain) underneath; 0 where nothing was modified.
        public static float DeltaAt(float wx, float wz)
        {
            float loc = LocationTerrain.DeltaAt(wx, wz);
            int zx = ZoneOf(wx), zz = ZoneOf(wz);
            if (!patches.TryGetValue(ZoneKey(zx, zz), out var p) || !p.anyHeight) return loc;
            return loc + Bilinear(p.delta, wx - (zx * ZoneSize - 32), wz - (zz * ZoneSize - 32));
        }

        // any terraforming or location ground in a box (a dictionary look per zone)
        public static bool AnyIn(float minX, float minZ, float maxX, float maxZ)
        {
            int x0 = ZoneOf(minX - 1f), x1 = ZoneOf(maxX + 1f), z0 = ZoneOf(minZ - 1f), z1 = ZoneOf(maxZ + 1f);
            for (int zx = x0; zx <= x1; zx++)
                for (int zz = z0; zz <= z1; zz++)
                    if (patches.ContainsKey(ZoneKey(zx, zz)) || LocationTerrain.Has(zx, zz)) return true;
            return false;
        }

        internal static float BilinearAt(float[] g, float fx, float fz) => Bilinear(g, fx, fz);

        // Paint at a world position: dirt, cultivated, paved, 0..1 each. False when unpainted.
        public static bool PaintAt(float wx, float wz, out float dirt, out float cultivated, out float paved)
        {
            dirt = cultivated = paved = 0f;
            float locDirt = LocationTerrain.DirtAt(wx, wz);   // (a location's cleared ground)
            int zx = ZoneOf(wx), zz = ZoneOf(wz);
            if (!patches.TryGetValue(ZoneKey(zx, zz), out var p) || !p.anyPaint) { dirt = locDirt; return dirt > 0.02f; }
            float fx = wx - (zx * ZoneSize - 32);
            float fz = wz - (zz * ZoneSize - 32);
            int i0 = (int)fx, j0 = (int)fz;
            if (i0 < 0) i0 = 0; if (i0 > W - 2) i0 = W - 2;
            if (j0 < 0) j0 = 0; if (j0 > W - 2) j0 = W - 2;
            float tx = fx - i0, tz = fz - j0;
            if (tx < 0) tx = 0; if (tx > 1) tx = 1; if (tz < 0) tz = 0; if (tz > 1) tz = 1;
            int a = (j0 * W + i0) * 3, b = a + 3, c = a + W * 3, d = c + 3;
            byte[] pm = p.paint;
            dirt       = Lerp(Lerp(pm[a], pm[b], tx), Lerp(pm[c], pm[d], tx), tz) / 255f;
            cultivated = Lerp(Lerp(pm[a + 1], pm[b + 1], tx), Lerp(pm[c + 1], pm[d + 1], tx), tz) / 255f;
            paved      = Lerp(Lerp(pm[a + 2], pm[b + 2], tx), Lerp(pm[c + 2], pm[d + 2], tx), tz) / 255f;
            dirt = Math.Max(dirt, locDirt);
            return dirt > 0.02f || cultivated > 0.02f || paved > 0.02f;
        }

        private static float Lerp(float a, float b, float t) => a + (b - a) * t;

        private static float Bilinear(float[] g, float fx, float fz)
        {
            int i0 = (int)fx, j0 = (int)fz;
            if (i0 < 0) i0 = 0; if (i0 > W - 2) i0 = W - 2;
            if (j0 < 0) j0 = 0; if (j0 > W - 2) j0 = W - 2;
            float tx = fx - i0, tz = fz - j0;
            if (tx < 0) tx = 0; if (tx > 1) tx = 1; if (tz < 0) tz = 0; if (tz > 1) tz = 1;
            int a = j0 * W + i0;
            float top = g[a] + (g[a + 1] - g[a]) * tx;
            float bot = g[a + W] + (g[a + W + 1] - g[a + W]) * tx;
            return top + (bot - top) * tz;
        }
    }
}
