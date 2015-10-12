using System;
using System.Diagnostics;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Example_15
{
    internal class Program
    {
        private static void Main()
        {
            Timed(() => {
                Parallel.For(0, 10, i => {
                    Thread.Sleep(1000);
                });
            }, "Counting to ten at 1s per number");


            var numbers = Enumerable.Range(0, 10);
            Timed(() => {
                Parallel.ForEach(numbers, i => {
                    Thread.Sleep(1000);
                });
            }, "Counting to ten at 1s per number");

            Parallel.For(0, 1000, (i, loopState) => {
                if (i == 500) {
                    Console.WriteLine("Breaking loop");
                    loopState.Break();
                }
            });

            Console.ReadLine();
        }

        static void Timed(Action action, string description)
        {
            var stopwatch = new Stopwatch();
            stopwatch.Start();
            action();
            stopwatch.Stop();
            Console.WriteLine("{0} takes {1} seconds.", description, stopwatch.Elapsed);
        }
    }
}