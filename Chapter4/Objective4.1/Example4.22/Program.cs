using System;
using System.IO;
using System.Net;

namespace Example4._22
{
    class Program
    {
        static void Main(string[] args)
        {
            WebRequest request = WebRequest.Create("http://www.microsoft.com");
            WebResponse response = request.GetResponse();

            StreamReader responseStream = new StreamReader(response.GetResponseStream());
            string responseText = responseStream.ReadToEnd();

            Console.WriteLine("Response from http://www.microsoft.com:");
            Console.WriteLine(responseText);

            response.Close();

            Console.Write("Press a key to exit ... ");
            Console.ReadKey();
        }
    }
}
