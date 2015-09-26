using System;
using System.Collections.Concurrent;

namespace Example1._30
{
    class Program
    {
        static void Main(string[] args)
        {
            ConcurrentBag<int> bag = new ConcurrentBag<int>();
            bag.Add(42);
            bag.Add(21);

            int result;
            if (bag.TryTake(out result))
            {
                Console.WriteLine(result);
            }

            if (bag.TryPeek(out result))
            {
                Console.WriteLine("There is a next item: {0}", result);
            }

            if (bag.TryTake(out result))
            {
                Console.WriteLine(result);
            }

            Console.Write("Press a key to exit");
            Console.ReadKey();
        }
    }
}
