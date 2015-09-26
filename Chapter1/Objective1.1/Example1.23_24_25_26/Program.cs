using System;
using System.Linq;

namespace Example1._23
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Enumerable.Range(0, 10);

            // 1.23
            // In no particular order
            var parallelResult = numbers.AsParallel()
                .Where(i => i % 2 == 0)
                .ToArray();
            Console.WriteLine("Printing parallelResult:");
            foreach (var number in parallelResult)
            {
                Console.WriteLine(number);
            }

            // 1.24
            // Order
            var parallelResult2 = numbers.AsParallel().AsOrdered()
                .Where(i => i % 2 == 0)
                .ToArray();
            Console.WriteLine("Printing parallelResult2:");
            foreach (var number in parallelResult2)
            {
                Console.WriteLine(number);
            }

            // 1.25
            var parallelResult3 = numbers.AsParallel().AsOrdered()
                .Where(i => i % 2 == 0)
                .AsSequential();
            Console.WriteLine("Printing parallelResult3:");
            foreach (var number in parallelResult3.Take(5))
            {
                Console.WriteLine(number);
            }

            //// 1.26
            var parallelResult4 = numbers.AsParallel()
                .Where(i => i % 2 == 0);

            Console.WriteLine("Printing parallelResult4:");
            parallelResult4.ForAll(e => Console.WriteLine(e));


            Console.Write("Press a key to exit");
            Console.ReadKey();
        }
    }
}
