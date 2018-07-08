using System;
using System.Threading;
using System.Threading.Tasks;

namespace Asynchronose
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Downloading started!");
            Download();
            Console.ReadLine();
        }


        static void Download()
        {
            Task.Run(() =>
            {
                Thread.Sleep(3000);
                Console.WriteLine("Download completed");
            });
        }
    }
}
