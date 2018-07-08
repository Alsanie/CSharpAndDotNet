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
            Console.WriteLine("Downloading started!");
            DownloadTimer();
            DownloadReal();
            Console.ReadLine();
        }


        static async void DownloadTimer()
        {
            // This will wait till the downlaod complete .
            // this require the key world 'async' in the function prototype
            await Network.Downlaod();  
            Console.WriteLine("Download completed");
        }

        static async void DownloadReal()
        {
            HttpClient client = new HttpClient();
            var data = await client.GetStringAsync("http://google.com");
            Console.WriteLine("Download completed" + data);
        }
    }

    class Network
    {
        static public Task Downlaod()
        {
            return Task.Run(() => Thread.Sleep(3000));
        }
    }
}
