// Nothing of ground nobody has walked leaves the server (spec F3; ticket tuiles-2d-brouillard). The
// map tiles stay whole on disk (no new render when the fog lifts); as each is served, every pixel
// over unwalked ground goes out transparent, colour and all, from the 12 m fog. A tile wholly walked
// goes out as it is, one wholly unwalked as an empty tile. The masked copies are kept by what of
// the tile is walked (its signature, also in the ETag), and the fog lifting tells open pages to
// fetch the tiles over that spot again (TileStore.OnFogLifted).
//
// The edge is soft, not the fog's 12 m stairs, and runs on under the page's blurred veil
// (layers/fog.js) so the ground goes into the dark cleanly: the walked cells are blurred (a 5x5
// binomial, Blurred), read between their centres (bilinear, Cover), and the ground fades out from
// the walked edge (Cover 1/2) to about a cell past it (Cover Lo), where the veil is near black.
// The blur first makes the edge a curve: straight from the cells, the line still showed their
// squares.
//
// Height tiles are left whole: the 3D view's relief of unwalked ground stays as decided on
// 12/11/2026 (ticket 3d-brouillard).
using System;
using System.Collections.Generic;
using System.IO;
using SixLabors.ImageSharp;
using SixLabors.ImageSharp.Formats.Png;
using SixLabors.ImageSharp.Formats.Webp;
using SixLabors.ImageSharp.PixelFormats;

namespace WebMap.Tiles
{
    internal static class FogMask
    {
        private const int N = TileMath.TILE_SIZE;
        private sealed class Kept { public string etag; public uint sig; public byte[] bytes; }
        private static readonly Dictionary<long, Kept> kept = new Dictionary<long, Kept>();
        private static readonly object gate = new object();
        private static byte[] empty;

        // for the tests: what counts as walked (world x, z)
        internal static Func<float, float, bool> Walked = MapFog.IsExplored;

        private const float Lo = 0.19f, Hi = 0.5f;
        private static readonly float[] K = { 1 / 16f, 4 / 16f, 6 / 16f, 4 / 16f, 1 / 16f };

        // a cell, centred on (i, j) cells from the world's middle: walked, 1 or 0
        private static float Cell(int i, int j)
        {
            float c = WebMapConfig.PIXEL_SIZE;
            return Walked(i * c, j * c) ? 1f : 0f;
        }

        // the cell (i, j) blurred with its neighbours, 0 to 1
        internal static float Blurred(int i, int j)
        {
            float v = 0;
            for (int dj = -2; dj <= 2; dj++)
                for (int di = -2; di <= 2; di++) v += K[di + 2] * K[dj + 2] * Cell(i + di, j + dj);
            return v;
        }

        // The blurred cells over an area (world metres), worked out once: a tile's pixels ask each
        // four times
        internal static Func<int, int, float> Cells(float minX, float minZ, float maxX, float maxZ)
        {
            float c = WebMapConfig.PIXEL_SIZE;
            int i0 = (int)Math.Floor(minX / c) - 3, j0 = (int)Math.Floor(minZ / c) - 3;
            int ni = (int)Math.Ceiling(maxX / c) + 4 - i0, nj = (int)Math.Ceiling(maxZ / c) + 4 - j0;
            if ((long)ni * nj > 4_500_000) return Blurred;            // (never at the sizes asked)
            var raw = new float[ni * nj];
            for (int j = 0; j < nj; j++)
                for (int i = 0; i < ni; i++) raw[j * ni + i] = Cell(i0 + i, j0 + j);
            var across = new float[ni * nj];
            for (int j = 0; j < nj; j++)
                for (int i = 2; i < ni - 2; i++)
                {
                    float v = 0; for (int d = -2; d <= 2; d++) v += K[d + 2] * raw[j * ni + i + d];
                    across[j * ni + i] = v;
                }
            var v2 = new float[ni * nj];
            for (int j = 2; j < nj - 2; j++)
                for (int i = 2; i < ni - 2; i++)
                {
                    float v = 0; for (int d = -2; d <= 2; d++) v += K[d + 2] * across[(j + d) * ni + i];
                    v2[j * ni + i] = v;
                }
            return (i, j) =>
            {
                int a = i - i0, b = j - j0;
                return a >= 2 && b >= 2 && a < ni - 2 && b < nj - 2 ? v2[b * ni + a] : Blurred(i, j);
            };
        }

        // How walked (x, z) is, 0 to 1: the blurred cells read bilinearly
        internal static float Cover(float x, float z, Func<int, int, float> cell = null)
        {
            cell = cell ?? Blurred;
            float c = WebMapConfig.PIXEL_SIZE, fx = x / c, fz = z / c;
            int ix = (int)Math.Floor(fx), iz = (int)Math.Floor(fz);
            float tx = fx - ix, tz = fz - iz;
            float a = cell(ix, iz), b = cell(ix + 1, iz), d = cell(ix, iz + 1), e = cell(ix + 1, iz + 1);
            return (a * (1 - tx) + b * tx) * (1 - tz) + (d * (1 - tx) + e * tx) * tz;
        }

        // what of the ground at (x, z) shows, 0 to 255: all up to the walked edge, none a cell past it
        internal static byte Shown(float x, float z, Func<int, int, float> cell = null)
        {
            float v = Cover(x, z, cell);
            if (v <= Lo) return 0;
            if (v >= Hi) return 255;
            float t = (v - Lo) / (Hi - Lo);
            return (byte)Math.Round(255f * t * t * (3f - 2f * t));
        }

        public static bool Masks(string layer) => layer == "map" || layer == "terra" || layer == "veg";

        // The tile as it may leave: `etag` comes back changed when the tile was masked
        public static byte[] Apply(string layer, int zoom, int x, int y, byte[] data, ref string etag)
        {
            if (!Masks(layer) || data == null) return data;
            var shown = new byte[N * N];
            int whole = 0, none = 0;
            TileMath.TileBounds(zoom, x, y, out float minX, out float minZ, out float maxX, out float maxZ);
            float step = (maxX - minX) / N;
            var cells = Cells(minX, minZ, maxX, maxZ);
            uint sig = 2166136261u;
            for (int py = 0; py < N; py++)
            {
                float wz = maxZ - (py + 0.5f) * step;
                for (int px = 0; px < N; px++)
                {
                    byte a = Shown(minX + (px + 0.5f) * step, wz, cells);
                    shown[py * N + px] = a;
                    if (a == 255) whole++; else if (a == 0) none++;
                    sig = (sig ^ a ^ ((uint)(py * N + px) << 8)) * 16777619u;
                }
            }
            if (whole == N * N) return data;
            if (none == N * N) { etag = "\"e\""; return Empty(); }
            string tag = etag;
            long key = TileMath.Key(zoom, x, y) ^ ((long)layer[0] << 56);
            lock (gate)
                if (kept.TryGetValue(key, out var k) && k.sig == sig && k.etag == tag) { etag = Tagged(tag, sig); return k.bytes; }
            byte[] masked = Mask(data, shown);
            if (masked == null) { etag = "\"e\""; return Empty(); }     // never the clear tile instead
            lock (gate)
            {
                if (kept.Count > 4000) kept.Clear();
                kept[key] = new Kept { etag = tag, sig = sig, bytes = masked };
            }
            etag = Tagged(tag, sig);
            return masked;
        }

        private static string Tagged(string etag, uint sig) => "\"" + (etag ?? "\"").Trim('"') + "-f" + sig.ToString("x") + "\"";

        // the pixels over unwalked ground: transparent and black (no colour left behind in them);
        // those along the edge partly so (shown: each pixel's 0 to 255)
        internal static byte[] Mask(byte[] data, byte[] shown)
        {
            try
            {
                bool webp = Util.WebP.IsWebp(data);
                using (var img = SixLabors.ImageSharp.Image.Load<Rgba32>(data))
                {
                    if (img.Width != N || img.Height != N) return null;
                    for (int py = 0; py < N; py++)
                        for (int px = 0; px < N; px++)
                        {
                            byte a = shown[py * N + px];
                            if (a == 255) continue;
                            if (a == 0) { img[px, py] = new Rgba32(0, 0, 0, 0); continue; }
                            var p = img[px, py];
                            p.A = (byte)(p.A * a / 255);
                            if (p.A == 0) p = new Rgba32(0, 0, 0, 0);
                            img[px, py] = p;
                        }
                    using (var ms = new MemoryStream(data.Length))
                    {
                        if (webp) img.SaveAsWebp(ms, new WebpEncoder { FileFormat = WebpFileFormatType.Lossless, Method = WebpEncodingMethod.Level0 });
                        else img.SaveAsPng(ms, new PngEncoder { CompressionLevel = PngCompressionLevel.BestSpeed });
                        return ms.ToArray();
                    }
                }
            }
            catch (Exception e) { ZLog.LogWarning("WebMap: tile mask failed: " + e.Message); return null; }
        }

        internal static byte[] Empty()
        {
            if (empty != null) return empty;
            using (var img = new Image<Rgba32>(N, N, new Rgba32(0, 0, 0, 0)))
            using (var ms = new MemoryStream()) { img.SaveAsPng(ms); return empty = ms.ToArray(); }
        }

        // The world picture (WorldPicture: `metres` square, north up): unwalked ground black (it
        // is a JPEG too), going dark along the edge the same way
        internal static void MaskPicture(Image<Rgba32> img, float metres)
        {
            float step = metres / img.Width, half = metres / 2f;
            var cells = Cells(-half, -half, half, half);
            for (int py = 0; py < img.Height; py++)
            {
                float wz = half - (py + 0.5f) * step;
                for (int px = 0; px < img.Width; px++)
                {
                    byte a = Shown((px + 0.5f) * step - half, wz, cells);
                    if (a == 255) continue;
                    if (a == 0) { img[px, py] = new Rgba32(0, 0, 0, 255); continue; }
                    var p = img[px, py];
                    img[px, py] = new Rgba32((byte)(p.R * a / 255), (byte)(p.G * a / 255), (byte)(p.B * a / 255), 255);
                }
            }
        }
    }
}
