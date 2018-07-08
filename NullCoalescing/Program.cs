using System;

namespace NullCoalescing
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "Hello";
            s = null;
            var s2 = s ?? "default";  // If s is Null, assign 'default' value instaed
            Console.WriteLine($"s2 = {s2}");

            // Operator '??' cant be applied to types such as int
            // To use it with int, you need to use 'int?' instaed of 'int'
            int? i = 1;
            i = null;
            var i2 = i ?? 0;
            Console.WriteLine($"i2 = {i2}");
        }
    }
}
