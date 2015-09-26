using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace Example4._24
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Getting HttpClient string with async operation:");
            var task = ReadAsyncHttpRequest();
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

        public static async Task ReadAsyncHttpRequest()
        {
            HttpClient client = new HttpClient();
            string result = await client.GetStringAsync("http://www.microsoft.com");
            Console.WriteLine();
            Console.WriteLine(result);
        }
    }
}
