// The link preview card (Munin Map's Server/Preview, ported; ticket fonctions-munin-hors-carte):
// Discord, Slack, iMessage and the like read Open Graph tags from a page when someone posts its
// address. Each page served gets them for this server: its name, a description (preview_description)
// and, when set, a picture (preview_image: a file served at /preview-image.<ext>, or a URL). The
// fixed tags the pages carry are taken out first.
using System;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using BepInEx;
using WebSocketSharp.Net;

namespace WebMap
{
    internal static class Preview
    {
        private static string cachedFile;
        private static DateTime cachedStamp;
        private static byte[] cachedBytes;
        private static bool warned;

        // the setting as a file path ($VAR, ${VAR}, %VAR% and a leading ~ expanded, relative paths under
        // BepInEx); null when it is a URL or empty
        internal static string FilePath()
        {
            string v = (WebMapConfig.PREVIEW_IMAGE ?? "").Trim().Trim('"');
            if (v.Length == 0 || IsUrl(v)) return null;
            v = Environment.ExpandEnvironmentVariables(v);
            v = Regex.Replace(v, @"\$\{(\w+)\}|\$(\w+)", m => Environment.GetEnvironmentVariable(m.Groups[1].Success ? m.Groups[1].Value : m.Groups[2].Value) ?? m.Value);
            if (v == "~" || v.StartsWith("~/", StringComparison.Ordinal)) v = (Environment.GetEnvironmentVariable("HOME") ?? "") + v.Substring(1);
            try { return Path.GetFullPath(Path.IsPathRooted(v) ? v : Path.Combine(Paths.BepInExRootPath, v)); } catch { return null; }
        }

        private static bool IsUrl(string v) => v.StartsWith("http://", StringComparison.OrdinalIgnoreCase) || v.StartsWith("https://", StringComparison.OrdinalIgnoreCase);

        internal static string ContentType(string file)
        {
            switch (Path.GetExtension(file ?? "").ToLowerInvariant())
            {
                case ".png": return "image/png";
                case ".jpg": case ".jpeg": return "image/jpeg";
                case ".webp": return "image/webp";
                case ".gif": return "image/gif";
                default: return null;
            }
        }

        // the picture's bytes, read again when the file changes; null when there is none
        internal static byte[] Image(out string ctype)
        {
            ctype = null;
            string f = FilePath();
            if (f == null || (ctype = ContentType(f)) == null) return null;
            try
            {
                var info = new FileInfo(f);
                if (!info.Exists || info.Length > 8L * 1024 * 1024) return null;
                lock (typeof(Preview))
                {
                    if (cachedFile != f || cachedStamp != info.LastWriteTimeUtc || cachedBytes == null)
                    { cachedBytes = File.ReadAllBytes(f); cachedFile = f; cachedStamp = info.LastWriteTimeUtc; }
                    return cachedBytes;
                }
            }
            catch { return null; }
        }

        // a page's HTML with this server's tags in its head, the fixed ones out
        internal static string Inject(string html, string title, string baseUrl, string image)
        {
            int head = html.IndexOf("</head>", StringComparison.OrdinalIgnoreCase);
            if (head < 0) return html;
            string desc = string.IsNullOrEmpty(WebMapConfig.PREVIEW_DESCRIPTION)
                ? "Carte en direct de " + title + " : constructions, portails, bateaux et joueurs."
                : WebMapConfig.PREVIEW_DESCRIPTION;
            var sb = new StringBuilder();
            Meta(sb, "property", "og:type", "website");
            Meta(sb, "property", "og:site_name", "ForgeMap");
            Meta(sb, "property", "og:title", title);
            Meta(sb, "property", "og:description", desc);
            Meta(sb, "name", "description", desc);
            if (baseUrl != null) Meta(sb, "property", "og:url", baseUrl + "/");
            if (image != null)
            {
                Meta(sb, "property", "og:image", image);
                Meta(sb, "name", "twitter:card", "summary_large_image");
                Meta(sb, "name", "twitter:image", image);
            }
            else Meta(sb, "name", "twitter:card", "summary");
            Meta(sb, "name", "twitter:title", title);
            Meta(sb, "name", "twitter:description", desc);
            string start = html.Substring(0, head), end = html.Substring(head);
            start = Regex.Replace(start, @"[ \t]*<meta\s+(?:property|name)=""(?:og:[^""]*|twitter:[^""]*|description)""[^>]*>\r?\n?", "", RegexOptions.IgnoreCase);
            return start + sb + end;
        }

        // the tags for this request: absolute addresses, from public_url when set, else from the address
        // the request came in on (X-Forwarded-* first, for a reverse proxy)
        internal static string Page(HttpListenerRequest req, string html)
        {
            string title = WebMap.serverInfo != null && WebMap.serverInfo.TryGetValue("serverName", out var n) && n is string s && s.Length > 0 ? s : "ForgeMap";
            string page = BaseUrl(req), img = null;
            string v = (WebMapConfig.PREVIEW_IMAGE ?? "").Trim().Trim('"');
            if (IsUrl(v)) img = v;
            else if (v.Length > 0)
            {
                byte[] b = Image(out _);
                if (b != null && page != null) img = page + "/preview-image" + Path.GetExtension(FilePath()).ToLowerInvariant() + "?v=" + Fnv(b).ToString("x");
                else if (b == null && !warned) { warned = true; ZLog.LogWarning("WebMap: preview_image '" + v + "' is not a PNG, JPEG, WebP or GIF file that can be read (looked at " + FilePath() + ")"); }
            }
            return Inject(html, title, page, img);
        }

        internal static string BaseUrl(HttpListenerRequest req)
        {
            string set = (WebMapConfig.PUBLIC_URL ?? "").Trim();
            if (!IsUrl(set)) set = (WebMapConfig.URL ?? "").Trim();
            if (IsUrl(set))
            {
                int q = set.IndexOfAny(new[] { '?', '#' }); if (q >= 0) set = set.Substring(0, q);
                return set.TrimEnd('/');
            }
            try
            {
                string proto = First(req.Headers["X-Forwarded-Proto"]) ?? req.Url.Scheme;
                string host = First(req.Headers["X-Forwarded-Host"]) ?? req.Headers["Host"] ?? req.Url.Authority;
                if (string.IsNullOrEmpty(host) || (proto != "http" && proto != "https") || !Regex.IsMatch(host, @"^[A-Za-z0-9.\-\[\]:]+$")) return null;
                return proto + "://" + host;
            }
            catch { return null; }
        }

        private static string First(string h) { if (string.IsNullOrEmpty(h)) return null; int c = h.IndexOf(','); return (c >= 0 ? h.Substring(0, c) : h).Trim().ToLowerInvariant(); }

        private static void Meta(StringBuilder sb, string attr, string key, string value) =>
            sb.Append("<meta ").Append(attr).Append("=\"").Append(key).Append("\" content=\"").Append(Html(value)).Append("\">\n");

        private static string Html(string s) => (s ?? "").Replace("&", "&amp;").Replace("\"", "&quot;").Replace("<", "&lt;").Replace(">", "&gt;");

        private static uint Fnv(byte[] d) { uint h = 2166136261; foreach (byte b in d) h = (h ^ b) * 16777619; return h; }
    }
}
