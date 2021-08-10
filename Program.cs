using System;

namespace Algos
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");
            var ret = ClosestToZero.Run(new int[]{-5,-10, 6, -5, 7});
            Console.WriteLine(ret);
            ret = ClosestToZero.Run(new int[]{-5,-10, 1, 0, -5, 7});
            Console.WriteLine(ret);
            ret = ClosestToZero.Run(new int[]{6 , 1, -7, 2, 8});
            Console.WriteLine(ret);
            ret = ClosestToZero.Run(new int[]{-9, -3, -1, -2});
            Console.WriteLine(ret);
            ret = ClosestToZero.Run(new int[]{-8, -4, -2, 0, 1, 3, 4});
            Console.WriteLine(ret);
            FindClosestValueInBST.Run();
            Algo3.Run();
        }
    }
}