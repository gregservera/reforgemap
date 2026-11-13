// Nothing of ground nobody has walked leaves the server (spec F3; ticket tuiles-2d-brouillard). The
// map tiles stay whole on disk (no new render when the fog lifts); as each is served, every pixel
// over unwalked ground goes out transparent, colour and all, from the 12 m fog. A tile wholly walked
// goes out as it is, one wholly unwalked as an empty tile. The masked copies are kept by what of
// the tile is walked (its signature, also in the ETag), and the fog lifting tells open pages to
// fetch the tiles over that spot again (TileStore.OnFogLifted).
//
// The edge is soft, not the fog's 12 m stairs: the fog is read between its cells' centres
// (bilinear, Cover) and the ground fades out over the last half cell before the walked edge, the
// line the page's blurred veil (layers/fog.js) darkens along. Along a straight edge nothing of an
// unwalked cell shows; only in the inner corner of a walked bend does a few metres' wedge of one.
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

        // How walked (x, z) is, 0 to 1: the fog's cells (centred on multiples of the cell) read
        // bilinearly
        internal static float Cover(float x, float z)
        {
            float c = WebMapConfig.PIXEL_SIZE, fx = x / c, fz = z / c;
            float ix = (float)Math.Floor(fx), iz = (float)Math.Floor(fz), tx = fx - ix, tz = fz - iz;
            float x0 = ix * c, x1 = x0 + c, z0 = iz * c, z1 = z0 + c;
            float a = Walked(x0, z0) ? 1f : 0f, b = Walked(x1, z0) ? 1f : 0f, d = Walked(x0, z1) ? 1f : 0f, e = Walked(x1, z1) ? 1f : 0f;
            return (a * (1 - tx) + b * tx) * (1 - tz) + (d * (1 - tx) + e * tx) * tz;
        }

        // what of the ground at (x, z) shows, 0 to 255: none at the walked edge (Cover 1/2), all
        // from the walked cells' centres in
        internal static byte Shown(float x, float z)
        {
            float v = Cover(x, z);
            if (v <= 0.5f) return 0;
            if (v >= 1f) return 255;
            float t = (v - 0.5f) * 2f;
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
            uint sig = 2166136261u;
            for (int py = 0; py < N; py++)
            {
                float wz = maxZ - (py + 0.5f) * step;
                for (int px = 0; px < N; px++)
                {
                    byte a = Shown(minX + (px + 0.5f) * step, wz);
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
            for (int py = 0; py < img.Height; py++)
            {
                float wz = half - (py + 0.5f) * step;
                for (int px = 0; px < img.Width; px++)
                {
                    byte a = Shown((px + 0.5f) * step - half, wz);
                    if (a == 255) continue;
                    if (a == 0) { img[px, py] = new Rgba32(0, 0, 0, 255); continue; }
                    var p = img[px, py];
                    img[px, py] = new Rgba32((byte)(p.R * a / 255), (byte)(p.G * a / 255), (byte)(p.B * a / 255), 255);
                }
            }
        }
    }
}
