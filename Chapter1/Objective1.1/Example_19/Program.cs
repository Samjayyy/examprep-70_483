using System;
using System.Linq;

namespace Example_19
{
    internal class Program
    {
        private static void Main()
        {
            var numbers = Enumerable.Range(0, 20);
            try {
                var parrallelResult = numbers.AsParallel().Where(IsEven);
                parrallelResult.ForAll(Console.WriteLine);
            } catch (AggregateException e) {
                Console.WriteLine("There were {0} exceptions.", e.InnerExceptions.Count);
            }
            Console.ReadLine();
        }

        private static bool IsEven(int i)
        {
            if (i % 10 == 0) {
                throw new ArgumentException("i");
            }
            return i % 2 == 0;
        }
    }
}