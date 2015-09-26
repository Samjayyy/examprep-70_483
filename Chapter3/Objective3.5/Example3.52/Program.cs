using System;
using System.Diagnostics;
using System.Text;

namespace Example3._52
{
    class Program
    {
        const int numberOfIterations = 100000;
        static void Main(string[] args)
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();
            Console.WriteLine("Algorithm1 started");
            Algorithm1();
            sw.Stop();

            Console.WriteLine(sw.Elapsed);

            sw.Reset();
            sw.Start();
            Console.WriteLine("Algorithm2 started");
            Algorithm2();
            sw.Stop();

            Console.WriteLine(sw.Elapsed);
            Console.WriteLine("Ready...");

            Console.WriteLine("Press a key to exit");
            Console.ReadKey();
        }

        private static void Algorithm1()
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < numberOfIterations; i++)
            {
                sb.Append('a');
            }

            string result = sb.ToString();
        }

        private static void Algorithm2()
        {
            string result = "";

            for (int i = 0; i < numberOfIterations; i++)
            {
                result += 'a';
            }
        }
    }
}
