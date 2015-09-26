using System;
using System.Collections.Concurrent;
using System.Threading;
using System.Threading.Tasks;

namespace Example1._31
{
    class Program
    {
        static void Main(string[] args)
        {
            ConcurrentBag<int> bag = new ConcurrentBag<int>();
            Task.Run(() =>
            {
                bag.Add(42);
                Thread.Sleep(1000);
                bag.Add(21);
            });
            Task.Run(() =>
            {
                foreach (int i in bag)
                {
                    Console.WriteLine(i);
                }
            });

            Console.Write("Press a key to exit");
            Console.ReadKey();
        }
    }
}
