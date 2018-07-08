using System;

namespace UsingStatement
{
    class myResource : IDisposable
    {
        public void Dispose()
        {
            Console.WriteLine("disposing our resources...");
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            using (var obj = new myResource())
            {
                // Doing stuff with obj
                Console.WriteLine("using myResource");
            }
            // At this poitn the 'Dispose() function will be called on 'obj'
        }
    }
}
