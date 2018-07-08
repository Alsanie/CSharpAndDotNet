using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace Asynchronose_await
{
    class Program
    {
        static void Main(string[] args)
        {
            Downlaod1();
            Downlaod2();
            Downlaod3();
            Console.ReadLine();
        }

        // Callback using regular callback function
        static void Downlaod1()
        {
            Network.Downlaod(OnDownload);
        }

        static void OnDownload()
        {
            Console.WriteLine("Downlaod completed - reguler function");
        }

        // Callback using Lambda experssion as a callback function
        static void Downlaod2()
        {
            Network.Downlaod(() => Console.WriteLine("Downlaod completed - Lambda function"));
        }

        // Callback and receving parameter
        static void Downlaod3()
        {
            Network.DownlaodPara((message) => Console.WriteLine("Downlaod completed - Lambda function " + message));
        }
    }

    class Network
    {
        static public Task Downlaod(Action callback)
        {
            return Task.Run(() =>
            {
                Thread.Sleep(3000);
                callback();   // When finihsed call the callback function
            });
        }

        static public Task DownlaodPara(Action<string> callback)
        {
            return Task.Run(() =>
            {
                Thread.Sleep(3000);
                callback("Here is your result message");   // When finihsed call the callback function
            });
        }
    }
}
