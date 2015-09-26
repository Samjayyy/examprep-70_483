using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace Example4._26
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Getting HttpClient string with parallel async operation:");
            var task = ExecuteMultipleRequestsInParallel();
            while (!task.IsCompleted)
            {
                Console.Write(@"...");
                Console.SetCursorPosition(0, Console.CursorTop);
            }

            Console.WriteLine();

            Console.WriteLine();
            Console.Write("Press a key to exit ... ");
            Console.ReadKey();
        }

        public static async Task ExecuteMultipleRequestsInParallel()
        {
            HttpClient client = new HttpClient();

            Task microsoft = client.GetStringAsync("http://www.microsoft.com");
            Task msdn = client.GetStringAsync("http://msdn.microsoft.com");
            Task blogs = client.GetStringAsync("http://blogs.msdn.com");

            await Task.WhenAll(microsoft, msdn, blogs);
        }
    }
}
