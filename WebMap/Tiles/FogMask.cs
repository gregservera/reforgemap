// Nothing of ground nobody has walked leaves the server (spec F3; ticket tuiles-2d-brouillard). The
// map tiles stay whole on disk (no new render when the fog lifts); as each is served, every pixel
// over unwalked ground goes out transparent, colour and all, from the 12 m fog. A tile wholly walked
// goes out as it is, one wholly unwalked as an empty tile. The masked copies are kept by what of
// the tile is walked (its signature, also in the ETag), and the fog lifting tells open pages to
// fetch the tiles over that spot again (TileStore.OnFogLifted).
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

        public static bool Masks(string layer) => layer == "map" || layer == "terra" || layer == "veg";

        // The tile as it may leave: `etag` comes back changed when the tile was masked
        public static byte[] Apply(string layer, int zoom, int x, int y, byte[] data, ref string etag)
        {
            if (!Masks(layer) || data == null) return data;
            var bits = new bool[N * N];
            int walked = 0;
            TileMath.TileBounds(zoom, x, y, out float minX, out float minZ, out float maxX, out float maxZ);
            float step = (maxX - minX) / N;
            uint sig = 2166136261u;
            for (int py = 0; py < N; py++)
            {
                float wz = maxZ - (py + 0.5f) * step;
                for (int px = 0; px < N; px++)
                {
                    bool w = Walked(minX + (px + 0.5f) * step, wz);
                    bits[py * N + px] = w;
                    if (w) walked++;
                    sig = (sig ^ (w ? 1u : 0u) ^ (uint)(py * N + px)) * 16777619u;
                }
            }
            if (walked == N * N) return data;
            if (walked == 0) { etag = "\"e\""; return Empty(); }
            string tag = etag;
            long key = TileMath.Key(zoom, x, y) ^ ((long)layer[0] << 56);
            lock (gate)
                if (kept.TryGetValue(key, out var k) && k.sig == sig && k.etag == tag) { etag = Tagged(tag, sig); return k.bytes; }
            byte[] masked = Mask(data, bits);
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

        // the pixels over unwalked ground: transparent and black (no colour left behind in them)
        internal static byte[] Mask(byte[] data, bool[] walked)
        {
            try
            {
                bool webp = Util.WebP.IsWebp(data);
                using (var img = SixLabors.ImageSharp.Image.Load<Rgba32>(data))
                {
                    if (img.Width != N || img.Height != N) return null;
                    for (int py = 0; py < N; py++)
                        for (int px = 0; px < N; px++)
                            if (!walked[py * N + px]) img[px, py] = new Rgba32(0, 0, 0, 0);
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

        // The world picture (WorldPicture: `metres` square, north up): unwalked ground black, it
        // is a JPEG too
        internal static void MaskPicture(Image<Rgba32> img, float metres)
        {
            float step = metres / img.Width, half = metres / 2f;
            for (int py = 0; py < img.Height; py++)
            {
                float wz = half - (py + 0.5f) * step;
                for (int px = 0; px < img.Width; px++)
                    if (!Walked((px + 0.5f) * step - half, wz)) img[px, py] = new Rgba32(0, 0, 0, 255);
            }
        }
    }
}
