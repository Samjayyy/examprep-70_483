using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace Example1._18
{
    class Program
    {
        static void Main(string[] args)
        {
            string result = DownloadContent().Result;

            Console.WriteLine(result);
            Console.Write("Press a key to exit");
            Console.ReadKey();
        }

        public static async Task<string>DownloadContent()
        {
            using (HttpClient client = new HttpClient())
            {
                string result = await client.GetStringAsync("http://www.microsoft.com");

                return result;
            }
        }
    }
}
