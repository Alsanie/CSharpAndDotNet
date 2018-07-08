using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Threading;

namespace Collection_ConcurrentDict
{
    class ProgramSafe
    {
        static ConcurrentDictionary<int, int> items = new ConcurrentDictionary<int, int>();

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Thread thread1 = new Thread(new ThreadStart(AddItem));
            Thread thread2 = new Thread(new ThreadStart(AddItem));

            thread1.Start();
            thread2.Start();
        }

        static void AddItem()
        {
            items.TryAdd(1, 10);
            Console.WriteLine(items.Count);
        }
    }
}
