using System;

namespace tryCatch_finally
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Coonecting to database ...");
            try
            {
                throw new Exception("Error while accessing database resouce");
            }
            catch(Exception)
            {
                Console.WriteLine("exception caught...");
            }
            finally  // this will ALWAYS executed in case of exception
            {
                Console.WriteLine("Disconect and clean up");
            }
        }
    }
}
