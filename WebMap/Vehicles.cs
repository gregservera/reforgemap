using System.Collections.Generic;
using System.Text;
using UnityEngine;

namespace WebMap
{
    // Boats and carts.
    //
    // Both are player-crafted, so they carry a creator on their ZDO and the
    // structures sweep was already finding them -- painting a karve as an
    // anonymous brown dot in the middle of the ocean. They are not buildings:
    // they move, and what anyone wants from them is "where did I leave it",
    // which wants a marker and a name rather than a pixel.
    //
    // Classified by component rather than prefab name, so a boat added in a
    // later patch is a boat without this needing to learn its name.
    internal static class Vehicles
    {
        internal enum Kind { None, Boat, Cart }

        private struct Entry { public Kind kind; public string name; public float x, z; public bool explored; }

        private static readonly Dictionary<int, Kind> kindCache = new Dictionary<int, Kind>();
        private static readonly Dictionary<int, string> nameCache = new Dictionary<int, string>();
        private static readonly List<Entry> found = new List<Entry>();
        private static volatile string json = "{\"boats\":0,\"carts\":0,\"vehicles\":[]}";

        public static Kind Classify(int prefabHash)
        {
            if (kindCache.TryGetValue(prefabHash, out var cached)) return cached;
            Kind k = Kind.None;
            string label = null;
            try
            {
                var go = ZNetScene.instance != null ? ZNetScene.instance.GetPrefab(prefabHash) : null;
                if (go != null)
                {
                    if (go.GetComponent<Ship>() != null) k = Kind.Boat;
                    else if (go.GetComponent<Vagon>() != null) k = Kind.Cart;
                    if (k != Kind.None) label = go.name;
                }
            }
            catch { }
            kindCache[prefabHash] = k;
            nameCache[prefabHash] = label ?? "";
            return k;
        }

        public static void Begin() => found.Clear();

        public static void Observe(int prefabHash, Kind kind, Vector3 pos)
        {
            nameCache.TryGetValue(prefabHash, out string name);
            // the fog is a texture, so it is sampled here on the game thread
            found.Add(new Entry { kind = kind, name = name ?? "", x = pos.x, z = pos.z, explored = MapFog.Explored(pos.x, pos.z) });
        }

        public static void Finish()
        {
            int boats = 0, carts = 0;
            var sb = new StringBuilder();
            sb.Append("{\"vehicles\":[");
            bool first = true;
            for (int i = 0; i < found.Count; i++)
            {
                var e = found[i];
                if (!WebMapConfig.SHOW_VEHICLES || !e.explored) continue;
                if (e.kind == Kind.Boat) boats++; else carts++;
                if (!first) sb.Append(",");
                first = false;
                string kind = e.kind == Kind.Boat ? "boat" : "cart";
                string name = e.name.Replace("\"", "");
                sb.Append(System.FormattableString.Invariant(
                    $"{{\"kind\":\"{kind}\",\"name\":\"{name}\",\"x\":{e.x:0.#},\"z\":{e.z:0.#}}}"));
            }
            sb.Append("],\"boats\":").Append(boats).Append(",\"carts\":").Append(carts).Append("}");
            json = sb.ToString();
            markersJson = MarkersFrom(found);
        }

        public static string GetJson() => json;

        // ---------- Munin's map: the vehicles as its marker set (Tiles/Markers) ----------
        private static volatile string markersJson = "[]";
        public static string GetMarkersJson() => markersJson;
        public static bool Refresh() => false;   // (Munin moves them between sweeps; ForgeMap at each sweep)
        private static string MarkersFrom(List<Entry> list)
        {
            var mk = new StringBuilder("[");
            foreach (var e in list)
            {
                if (!WebMapConfig.SHOW_VEHICLES || !e.explored) continue;
                string kind = e.kind == Kind.Boat ? "boat" : "cart";
                if (mk.Length > 1) mk.Append(',');
                mk.Append(System.FormattableString.Invariant($"{{\"x\":{e.x:0.#},\"z\":{e.z:0.#},\"cat\":\"{kind}\",\"icon\":\"{IconOf(kind, e.name)}\",\"label\":\"{PrettyName(e.name).Replace("\"", "")}\"}}"));
            }
            return mk.Append(']').ToString();
        }
        // each kind of boat its own icon (Munin's web/js/icons.js)
        private static string IconOf(string kind, string prefab)
        {
            if (kind != "boat") return kind;
            switch ((prefab ?? "").ToLowerInvariant())
            {
                case "raft": return "raft";
                case "karve": return "karve";
                case "vikingship": return "longship";
                case "vikingship_ashlands": return "drakkar";
                case "trailership": return "trailership";
                default: return "boat";
            }
        }
        private static string PrettyName(string prefab)
        {
            switch ((prefab ?? "").ToLowerInvariant())
            {
                case "raft": return "Raft";
                case "karve": return "Karve";
                case "vikingship": return "Longship";
                case "vikingship_ashlands": return "Drakkar";
                case "trailership": return "Trailer ship";
                case "cart": return "Cart";
                default: return (prefab ?? "").Replace("_", " ");
            }
        }
    }
}
