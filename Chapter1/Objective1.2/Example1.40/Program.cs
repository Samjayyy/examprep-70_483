using System;
using System.Threading;
using System.Threading.Tasks;

namespace Example1._40
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 0;
            var up = Task.Run(() =>
                {
                    for (int i = 0; i < 1000000; i++)
                    {
                        Interlocked.Increment(ref n);
                    }
                });

            for (int i = 0; i < 1000000; i++)
            {
                Interlocked.Decrement(ref n);
            }

            up.Wait();
            Console.WriteLine(n);
            if (Interlocked.Exchange(ref n, 1) == 0)
            {
                Console.WriteLine(n);
            }
            Console.Write("Press a key to exit");
            Console.ReadKey();
        }
    }
}
