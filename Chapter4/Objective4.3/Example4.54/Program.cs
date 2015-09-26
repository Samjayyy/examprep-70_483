using System;
using System.Linq;

namespace Example4._54
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] data = { 1, 2, 5, 8, 11 };
            Console.WriteLine("Creating query for all even numbers in data ...");
            // In query syntax
            var result = from d in data
                         where d % 2 == 0
                         select d;

            // Or in a method syntax
            //var result = data.Where(d => d % 2 == 0);

            Console.Write("Result: ");
            Console.WriteLine(string.Join(", ", result));
           
            Console.WriteLine();
            Console.Write("Press a key to exit ... ");
            Console.ReadKey();
        }
    }
}
