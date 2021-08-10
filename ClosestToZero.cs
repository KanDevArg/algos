using System;

namespace Algos
{
    internal static class ClosestToZero
    {
        public static int Run(int[] ints)
        {
            Console.WriteLine("ClosestToZero");
            
            var candidate = 0;
            Array.Sort(ints);
            // -5,-10, 6, -5, 7
            // -5,-7, 1, -5, 7
            // 5,6,1,2
            //-9,-3,-1,-2
            
            var ix_0 =  Array.IndexOf(ints, 0);
            if (ix_0 > -1)
            {
                return ints[ix_0];
            }
            
            if (ints[0] >= 0)
            {
                return ints[0];
            }
            
            if (ints[^1] <= 0)
            {
                return ints[^1];
            }
            
            foreach (var i in ints)
            {
                if (i < 0)
                {
                    candidate = i;
                }

                if (i >= 0)
                {
                    if (Math.Abs(i) < Math.Abs(candidate))
                    {
                        candidate = i;
                        break;
                    }   
                }
            }
            
            return candidate;
        }
    }
}