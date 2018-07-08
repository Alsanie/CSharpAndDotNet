using System;
using System.Collections.Generic;
using System.Threading;

namespace Collection_ConcurrentDict
{
    /*
    class ProgramBad
    {
        static Dictionary<int, int> items = new Dictionary<int, int>();

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
            items.Add(1, 10);
        }
    }
    */
}
