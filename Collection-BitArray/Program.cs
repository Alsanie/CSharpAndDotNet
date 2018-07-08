using System;
using System.Collections;

namespace Collection_BitArray
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            // Example 1
            BitArray enemyGrid = new BitArray(3);
            enemyGrid[0] = false;
            enemyGrid[1] = true;
            enemyGrid.Set(2, true);

            foreach (var item in enemyGrid)
            {
                Console.WriteLine(item);
            }

            // Example 2
            bool[] preload = new bool[3] { false, true, false };
            BitArray goodGrid = new BitArray(preload);

            foreach (var item in goodGrid)
            {
                Console.WriteLine(item);
            }
        }
    }
}
