using System;
using System.Threading.Tasks;

namespace Example1._8
{
    class Program
    {
        public static void Main(string[] args)
        {
            Task t = Task.Run(() =>
            {
                for (int x = 0; x < 100; x++)
                {
                    Console.Write("*");
                }
            });

            t.Wait();
            Console.Write("Press a key to exit");
            Console.ReadKey();
        }
    }
}
