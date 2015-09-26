using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace Example4._25
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Getting HttpClient string with async operation:");
            var task = ExecuteMiltiplerequests();
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

        public static async Task ExecuteMiltiplerequests()
        {
            HttpClient client = new HttpClient();

            string microsoft = await client.GetStringAsync("http://www.microsoft.com");
            Console.WriteLine(microsoft);
            string msdn = await client.GetStringAsync("http://msdn.microsoft.com");
            Console.WriteLine(msdn);
            string blogs = await client.GetStringAsync("http://blogs.msdn.com");
            Console.WriteLine(blogs);
        }
    }
}
