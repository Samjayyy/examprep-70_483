using System;
using System.Net.Http;

namespace Example2._21
{
    class Program
    {
        static void Main(string[] args)
        {
            HttpClient client = new HttpClient();
            object o = client;
            IDisposable d = client;

            Console.WriteLine($"client = {client}");
            Console.WriteLine($"o = {o}");
            Console.WriteLine($"d = {d}");

            Console.Write("Press a key to exit");
            Console.ReadKey();
        }
    }
}
