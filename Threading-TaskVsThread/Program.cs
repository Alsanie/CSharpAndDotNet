using System;
using System.Threading;
using System.Threading.Tasks;

namespace Threading_TaskVsThread
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int i = 0; i < 10; i++)
            {
                // Will create new thread each time
                Thread myThread = new Thread(new ThreadStart(work));
                myThread.Start();

                // Will reuse threads whenever possible (Managed by thread pool)
                Task.Run(() =>
                {
                    Console.WriteLine("Starting task " + Thread.CurrentThread.ManagedThreadId);
                    Thread.Sleep(3000); // simulate work
                    Console.WriteLine("Work completed");
                });
            }
        }

        static void work()
        {
            Console.WriteLine("Starting thread " + Thread.CurrentThread.ManagedThreadId);
            Thread.Sleep(3000); // simulate work
            Console.WriteLine("Work completed");
        }
    }
}
