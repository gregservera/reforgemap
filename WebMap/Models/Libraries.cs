// ForgeMap 2.0's two model libraries (decision D2a): player buildings keep ForgeMap's models
// (Models/, map_data/models/), everything else (trees, rocks, bushes, the world's locations) gets
// Munin's (MuninModels/, map_data/models-munin/), whose textures and materials are nearer the game.
// A prefab is exported by one of them only. The 3D view reads one index (/data/prefabs.json) and
// one folder (/models/): both are put together here.
using System;
using System.IO;
using WebMap.Util;

namespace WebMap.Models
{
    internal static class Libraries
    {
        // which library makes a prefab of this category
        public static bool IsForgeMaps(string cat) => cat == "piece" || cat == Rig.Cat;

        public static void Request(int hash, string cat, bool mineRock = false)
        {
            if (mineRock)
            {
                lock (mineRocks) if (mineRocks.Add(hash)) ZLog.Log($"WebMap: {cat} {hash}: a rock mined in pieces, ForgeMap's model");
                ModelStore.Request(hash, cat);
            }
            else if (IsForgeMaps(cat)) ModelStore.Request(hash, cat);
            else MuninModels.ModelStore.Request(hash, cat);
        }

        // Munin's entry when it has a model; else ForgeMap's (its models from before 2.0 stand in
        // until Munin's export is done); buildings always ForgeMap's
        // A rock mined in pieces stays ForgeMap's too: its export records each piece's hit area, which
        // the 3D view needs to leave the mined ones out (Munin's records none). WorldObjects knows.
        private static readonly System.Collections.Generic.HashSet<int> mineRocks = new System.Collections.Generic.HashSet<int>();

        internal static bool FromMunin(int hash)
        {
            if (ModelStore.Has(hash, out string cat, out _) && (IsForgeMaps(cat) || ModelStore.RockKindOf(hash) > 0)) return false;
            if (MuninModels.ModelStore.Has(hash, out _, out bool ok) && ok) return true;
            return !ModelStore.Has(hash, out _, out _) && MuninModels.ModelStore.Has(hash, out _, out _);
        }

        private static string json;
        private static long jsonOf = -1;
        public static string PrefabsJson
        {
            get
            {
                long of = ((long)ModelStore.Rev << 32) ^ (uint)MuninModels.ModelStore.Rev;
                string j0 = json;
                if (j0 != null && of == jsonOf) return j0;
                var j = new JsonWriter(64 * 1024);
                j.BeginObject().Prop("rev", ModelStore.Rev + MuninModels.ModelStore.Rev)
                 .Prop("exported", ModelStore.Exported + MuninModels.ModelStore.Exported).Prop("readable", ModelStore.Readable + MuninModels.ModelStore.Readable)
                 .Prop("unreadable", ModelStore.Unreadable + MuninModels.ModelStore.Unreadable).Prop("queued", ModelStore.QueueLength + MuninModels.ModelStore.QueueLength)
                 .Key("prefabs").BeginObject();
                foreach (int h in ModelStore.Hashes) if (!FromMunin(h)) ModelStore.WriteEntry(j, h);
                foreach (int h in MuninModels.ModelStore.Hashes) if (FromMunin(h)) MuninModels.ModelStore.WriteEntry(j, h);
                j.End().End();
                json = j.ToString(); jsonOf = of;
                return json;
            }
        }

        // the folder a file under /models/ is in: a model by whose entry is served, a texture
        // wherever it is (ForgeMap's first)
        public static string RootFor(string name)
        {
            if (name.EndsWith(".glb", StringComparison.Ordinal) && name.Length == 12
                && uint.TryParse(name.Substring(0, 8), System.Globalization.NumberStyles.HexNumber, null, out uint u))
                return FromMunin(unchecked((int)u)) ? MuninModels.ModelStore.Root : ModelStore.Root;
            string mine = ModelStore.Root, munin = MuninModels.ModelStore.Root;
            if (mine != null && File.Exists(Path.Combine(mine, name))) return mine;
            return munin ?? mine;
        }
    }
}
