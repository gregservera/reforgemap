// Munin's model settings, as ForgeMap has them (MuninModels: the exporter ported from Munin Map, MIT).
namespace WebMap.MuninModels
{
    internal static class MuninConfig
    {
        public static bool DEBUG => WebMapConfig.DEBUG;
        public static bool EXPORT_MODELS => WebMapConfig.EXPORT_MODELS;
        public static bool EXTRACT_MESHES => WebMapConfig.EXTRACT_MESHES;
        public static bool USE_TEXTURES => WebMapConfig.EXTRACT_TEXTURES;     // (light mode turns both off)
        public static bool ENABLE_3D => true;                                 // the 3D view is always on in 2.0
        public static int TEXTURE_MAX_SIZE => WebMapConfig.TEXTURE_MAX_SIZE;
        public static int MODEL_EXPORT_MS_PER_FRAME => WebMapConfig.EXPORT_MS_PER_FRAME;
    }
}
