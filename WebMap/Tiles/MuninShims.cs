// ForgeMap: what Munin Map's ported code (Markers, Runestones, Dungeons) asks of Munin's own Live
// classes, answered from ForgeMap's: the game's text in the server's language, a player's name from
// their id, the players known.
using System;
using System.Collections.Generic;

namespace WebMap.Tiles
{
    internal static class Live
    {
        internal static class WorldEvents
        {
            // a $token in the game's words; fallback when the game has none
            internal static string Localize(string s, string fallback)
            {
                if (string.IsNullOrEmpty(s)) return fallback;
                try
                {
                    string t = LocalizeFn(s);
                    if (!string.IsNullOrEmpty(t) && !t.StartsWith("$", StringComparison.Ordinal) && !t.StartsWith("[", StringComparison.Ordinal)) return t;
                }
                catch { }
                return fallback;
            }

            // the game's Localization, found by reflection (its assembly is not one ForgeMap builds against)
            private static bool looked;
            private static Func<string, string> localizer;
            private static string LocalizeFn(string s)
            {
                if (!looked)
                {
                    looked = true;
                    foreach (var asm in AppDomain.CurrentDomain.GetAssemblies())
                    {
                        var type = asm.GetType("Localization", false);
                        if (type == null) continue;
                        var inst = type.GetProperty("instance", System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.Static);
                        var loc = type.GetMethod("Localize", new[] { typeof(string) });
                        if (inst == null || loc == null) continue;
                        localizer = (x) => { var o = inst.GetValue(null, null); return o == null ? x : (string)loc.Invoke(o, new object[] { x }); };
                        break;
                    }
                }
                return localizer != null ? localizer(s) : s;
            }
        }

        internal static class Stats
        {
            internal static string NameOfPlayerId(long id) => id == 0L ? null : global::WebMap.Stats.NameOf(id);
            internal static List<string> Keys() => global::WebMap.Stats.Names();
        }
    }
}
