using System;
using System.Collections.Generic;

namespace CSharpAndDotNet
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            /*** NOTE: ArrayList has been dperecated. ***/

            List<string> customers = new List<string>();

            customers.Add("Bassam");
            customers.Add("Diana");
            customers.Add("Amal");

            Console.WriteLine(customers.Count);

            foreach (var item in customers)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine(customers[1]);
        }
    }
}
