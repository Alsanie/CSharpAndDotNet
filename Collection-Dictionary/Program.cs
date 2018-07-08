using System;
using System.Collections.Generic;

namespace Collection_Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            /*** NOTE: HashTable has been deprecated ***/
            Dictionary<string, string> config = new Dictionary<string, string>();

            config.Add("resolution", "1920x1080");
            config.Add("title", "Mywebsite");

            Console.WriteLine(config["title"]);
            foreach (var item in config)
            {
                Console.WriteLine(item);
                Console.WriteLine(item.Key);
                Console.WriteLine(item.Value);
            }
        }
    }
}
