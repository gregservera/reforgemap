// Ported from Munin Map 3.3.1 (cocopuff2u-gaming/munin-map, 8c376b2), MIT: the frame budget and
// the content-hash helpers of its WorldSweep, which the ported tile code calls. The walk itself is
// still StructureMap's.
using System.Diagnostics;
using UnityEngine;

namespace WebMap.Tiles
{
    internal static class WorldSweep
    {
        // game-thread milliseconds a frame the steps after the walk may take before yielding
        private const double BudgetMs = 4.0;
        private static readonly Stopwatch slice = new Stopwatch();
        private static int sliceFrame = -1;

        // true once this frame's share is spent: the caller yields and goes on next frame
        public static bool Due { get { NewFrame(); return slice.Elapsed.TotalMilliseconds >= BudgetMs; } }

        // Unity may resume a step a frame later than it paused, so a new frame always starts a new slice
        private static void NewFrame()
        {
            if (Time.frameCount == sliceFrame) return;
            sliceFrame = Time.frameCount;
            slice.Restart();
        }

        // order-independent content hashes: sum the mixed items, then fold with the count
        public static long Mix(int v)
        {
            uint x = unchecked((uint)v);
            x ^= x >> 16; x = unchecked(x * 0x7feb352d); x ^= x >> 15; x = unchecked(x * 0x846ca68b); x ^= x >> 16;
            return x;
        }
        public static int Fold(long sum, int count) => unchecked((int)(sum ^ (sum >> 32)) * 31 + count);
    }
}
