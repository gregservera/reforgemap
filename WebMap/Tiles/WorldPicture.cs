// ForgeMap's one picture of the whole world (/map, /map.jpg: the Portails, Plan and Monde pages draw
// on it), made from Munin's map tiles so those pages look like the map (ticket map-jpg-depuis-tuiles).
//
// Munin's tiles cover WORLD_SIZE metres; ForgeMap's picture covers TEXTURE_SIZE x PIXEL_SIZE metres
// (24 576 at the defaults), RENDER_SIZE pixels a side, north up. The zoom-4 tiles (8 m a pixel; 5 past
// 8 192 pixels) are stitched into one canvas, scaled to the picture's metres per pixel and centred;
// the margin takes the colour of the tiles' own far corner (the open sea past the world's edge).
//
// Made on a worker once every tile it needs is drawn (asking for the missing ones), then again when
// the tile store has drawn more since (at most every ten minutes). Kept as map.png beside the world,
// so a restart has it at once. Rev goes up with each new picture (/state's rev.map).
using System;
using System.Collections;
using System.IO;
using System.Threading;
using SixLabors.ImageSharp;
using SixLabors.ImageSharp.Formats.Jpeg;
using SixLabors.ImageSharp.Formats.Png;
using SixLabors.ImageSharp.PixelFormats;
using SixLabors.ImageSharp.Processing;
using UnityEngine;

namespace WebMap.Tiles
{
    internal static class WorldPicture
    {
        public static volatile byte[] Png, Jpg;
        public static volatile int Rev;
        private static string path;
        private static int composing, drawnAt = -1;
        private static float composedAt = -1e9f;
        private const float Every = 600f;

        public static void Load(string worldDataPath)
        {
            path = Path.Combine(worldDataPath, "map.png");
            Png = Jpg = null; drawnAt = -1; composedAt = -1e9f;
            try
            {
                if (!File.Exists(path)) return;
                byte[] png = File.ReadAllBytes(path);
                using (var img = SixLabors.ImageSharp.Image.Load<Rgba32>(png))
                {
                    if (img.Width != WebMapConfig.RENDER_SIZE) return;     // another size asked for since: made again
                    Jpg = EncodeJpg(img);
                }
                Png = png; Rev++;
            }
            catch (Exception e) { ZLog.LogWarning("WebMap: map.png not readable: " + e.Message); }
        }

        public static int ZoomFor(int renderSize) => renderSize > 8192 ? 5 : 4;

        // main thread, every 15 s: compose when due and every tile is there
        public static IEnumerator Loop()
        {
            yield return new WaitForSeconds(20f);
            while (true)
            {
                try { MaybeCompose(); } catch (Exception e) { ZLog.LogWarning("WebMap: world picture: " + e.Message); }
                yield return new WaitForSeconds(15f);
            }
        }

        private static void MaybeCompose()
        {
            if (path == null || composing != 0) return;
            int drawn = TileStore.Rendered;
            if (Png != null && (drawn == drawnAt || Time.realtimeSinceStartup - composedAt < Every)) return;
            int zoom = ZoomFor(WebMapConfig.RENDER_SIZE), n = TileMath.TilesPerSide(zoom);
            var got = new byte[n * n][];
            int missing = 0;
            for (int y = 0; y < n; y++)
                for (int x = 0; x < n; x++)
                    if ((got[y * n + x] = TileStore.Get("map", zoom, x, y, out _)) == null) missing++;   // (a miss asks for it)
            if (missing > 0) return;
            composing = 1;
            int size = WebMapConfig.RENDER_SIZE;
            float metres = WebMapConfig.TEXTURE_SIZE * WebMapConfig.PIXEL_SIZE;
            ThreadPool.QueueUserWorkItem(_ =>
            {
                try
                {
                    var sw = System.Diagnostics.Stopwatch.StartNew();
                    using (var img = Compose((x, y) => got[y * n + x], zoom, size, metres))
                    {
                        byte[] png;
                        using (var ms = new MemoryStream()) { img.SaveAsPng(ms, new PngEncoder { CompressionLevel = PngCompressionLevel.DefaultCompression }); png = ms.ToArray(); }
                        Jpg = EncodeJpg(img);
                        Png = png;
                        Rev++;
                        try { File.WriteAllBytes(path, png); } catch (Exception e) { ZLog.LogWarning("WebMap: map.png not saved: " + e.Message); }
                    }
                    ZLog.Log($"WebMap: world picture made from the zoom-{zoom} tiles in {sw.ElapsedMilliseconds} ms ({size} px)");
                }
                catch (Exception e) { ZLog.LogWarning("WebMap: world picture failed: " + e.Message); }
                finally { drawnAt = drawn; composing = 0; }
            });
            composedAt = Time.realtimeSinceStartup;
        }

        private static byte[] EncodeJpg(Image<Rgba32> img)
        {
            using (var ms = new MemoryStream()) { img.SaveAsJpeg(ms, new JpegEncoder { Quality = 85 }); return ms.ToArray(); }
        }

        // The picture: `size` pixels a side over `metres`, centred on the world's middle, from the tiles
        // of `zoom` (tile(x, y): its PNG or WebP bytes; y = 0 is the north row).
        internal static Image<Rgba32> Compose(Func<int, int, byte[]> tile, int zoom, int size, float metres)
        {
            int n = TileMath.TilesPerSide(zoom), px = TileMath.TILE_SIZE;
            using (var canvas = new Image<Rgba32>(n * px, n * px))
            {
                for (int y = 0; y < n; y++)
                    for (int x = 0; x < n; x++)
                    {
                        byte[] b = tile(x, y);
                        if (b == null) continue;
                        using (var t = SixLabors.ImageSharp.Image.Load<Rgba32>(b))
                            canvas.Mutate(c => c.DrawImage(t, new Point(x * px, y * px), 1f));
                    }
                // the tiles' metres in the picture's pixels
                float perPixel = metres / size;
                int side = Math.Max(1, (int)Math.Round(n * TileMath.TileSpanMeters(zoom) / perPixel));
                int at = (int)Math.Round((metres / 2f - TileMath.WORLD_HALF) / perPixel);
                Rgba32 sea = canvas[0, 0];
                sea.A = 255;
                var picture = new Image<Rgba32>(size, size, sea);
                canvas.Mutate(c => c.Resize(side, side, KnownResamplers.Triangle));
                picture.Mutate(c => c.DrawImage(canvas, new Point(at, at), 1f));
                return picture;
            }
        }
    }
}
