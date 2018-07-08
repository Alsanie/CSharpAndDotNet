using System;
using System.Threading;

namespace Threading
{
    /* Notes:
     * Thread: is a low level API
     * Task  : is a high level threading managment that auto manage thread pool for us.
     *            Used to write auto managed asynchronis code.
    */

    class Program
    {
        static void Main(string[] args)
        {
            Thread myThread = new Thread(new ThreadStart(work));
            myThread.Start();
        }

        static void work()
        {
            Thread.Sleep(3000); // simulate work
            Console.WriteLine("Work completed");
        }
    }
}
