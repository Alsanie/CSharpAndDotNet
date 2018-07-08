using System;

namespace StringInterpolation
{
    class Program
    {
        static void Main(string[] args)
        {
            var point = new { x = 1, y = 2 };

            // Slow, as it re allocate for every concatenation operator '+'
            Console.WriteLine("x " + point.x + " y " + point.y);

            // Ok, but in case chnaged the order of the print, you need to chnage the order of the parameters
            Console.WriteLine("x {0} y {1}", point.x, point.y);

            // Best :)
            Console.WriteLine($"x {point.x} y {point.y}");
        }
    }
}
