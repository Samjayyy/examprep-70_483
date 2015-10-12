using System;
using System.Collections.Concurrent;
using System.Threading;
using System.Threading.Tasks;

namespace Example_21
{
    internal class Program
    {
        private static void Main()
        {
            var bag = new ConcurrentBag<int>();
            Task.Run(() => {
                bag.Add(42);
                Thread.Sleep(1000);
                bag.Add(21);
            });
            Task.Run(() => {
                foreach (var i in bag) {
                    Console.WriteLine(i);
                }
            });

            Console.Write("Press a key to exit");
            Console.ReadKey();
        }
    }
}