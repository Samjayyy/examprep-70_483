using System;
using System.Linq;

namespace Example_18
{
    internal class Program
    {
        private static void Main()
        {
            var numbers = Enumerable.Range(0, 10).ToArray();

            // In no particular order
            var parallelResult = numbers.AsParallel()
                .Where(i => i % 2 == 0)
                .ToArray();
            Console.WriteLine("No guaranteed order:");
            foreach (var number in parallelResult) {
                Console.WriteLine(number);
            }

            // Order
            var parallelResult2 = numbers.AsParallel().AsOrdered()
                .Where(i => i % 2 == 0)
                .ToArray();
            Console.WriteLine("Ordered:");
            foreach (var number in parallelResult2) {
                Console.WriteLine(number);
            }

            var parallelResult3 = numbers.AsParallel().AsOrdered()
                .Where(i => i % 2 == 0)
                .AsSequential();
            Console.WriteLine("Partly Sequential:");
            foreach (var number in parallelResult3.Take(5)) {
                Console.WriteLine(number);
            }

            var parallelResult4 = numbers.AsParallel()
                .Where(i => i % 2 == 0);

            Console.WriteLine("Parallel ForAll:");
            parallelResult4.ForAll(Console.WriteLine);

            Console.ReadLine();
        }
    }
}