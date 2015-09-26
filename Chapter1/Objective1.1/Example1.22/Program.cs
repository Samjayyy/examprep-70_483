using System;
using System.Linq;
using System.Text;

namespace Example1._22
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Enumerable.Range(0, 100);
            var parallelResult = numbers.AsParallel()
                .Where(i => i %5 == 0)
                .ToArray();
            StringBuilder result = new StringBuilder();

            foreach (var number in parallelResult)
            {
                result.AppendLine(number.ToString());
            }

            Console.Write(result);
            Console.Write("Press a key to exit");
            Console.ReadKey();
        }
    }
}
