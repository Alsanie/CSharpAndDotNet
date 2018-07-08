using System;

namespace TryCatch
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string s = null;
                var s1 = s.Length;

                // or try
                // throw new Exception("my exception");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
    }
}
