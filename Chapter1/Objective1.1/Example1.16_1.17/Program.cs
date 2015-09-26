using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Example1._16
{
    class Program
    {
        static void Main(string[] args)
        {
            Parallel.For(0, 10, i =>
                {
                    Thread.Sleep(1000);
                });

            var numbers = Enumerable.Range(0, 10);
            Parallel.ForEach(numbers, i =>
                {
                    Thread.Sleep(1000);
                });

            ParallelLoopResult results = Parallel.For(0, 1000, (int i, ParallelLoopState loopState) =>
                {
                    if (i == 500)
                    {
                        Console.WriteLine("Breaking loop");
                        loopState.Break();
                    }

                    return;
                });

            Console.Write("Press a key to exit");
            Console.ReadKey();
        }
    }
}
