using System;
using System.Collections.Generic;

namespace Collection_HashSet
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            HashSet<string> myHashSet = new HashSet<string>();

            myHashSet.Add("Hello");
            myHashSet.Add("Hello"); // will not be added, as its dulicate. No error

            Console.WriteLine(myHashSet.Count);  // will print 1 only s the second item was duplicate

            // Nice fnction in hashset is overlap
            string[] s = new string[] { "Hello" };
            bool isIt = myHashSet.Overlaps(s);
            Console.WriteLine(isIt);
        }
    }
}
