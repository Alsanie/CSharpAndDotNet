using System;

namespace Collection_Tuple
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            //Example 1
            Tuple<int, string, bool> myTuple = new Tuple<int, string, bool>(1, "Hello", true);
            Console.WriteLine(myTuple.Item3);

            // Example 2
            var myOtherTuple = Tuple.Create(2, "There", false);
            Console.WriteLine(myOtherTuple.Item3);

        }
    }
}
