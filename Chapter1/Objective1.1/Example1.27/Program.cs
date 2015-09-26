using System;
using System.Linq;

namespace Example1._27
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Enumerable.Range(0, 20);

            try
            {
                var parrallelResult = numbers.AsParallel()
                    .Where(i => IsEven(i));
                parrallelResult.ForAll(e => Console.WriteLine(e));
            }
            catch (AggregateException e)
            {
                Console.WriteLine(string.Format("There where {0} excpetions.", e.InnerExceptions.Count));
            }

            Console.Write("Press a key to exit");
            Console.ReadKey();
        }

        private static bool IsEven(int i)
        {
            if (i % 10 == 0)
            {
                throw new ArgumentException("i");
            }

            return i % 2 == 0;
        }
    }
}
