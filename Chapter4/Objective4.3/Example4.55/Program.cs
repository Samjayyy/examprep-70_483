using System;
using System.Linq;

namespace Example4._55
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] data = { 1, 2, 5, 8, 11 };
            Console.Write("All: ");
            var result = from d in data
                         select d;
            Console.WriteLine(string.Join(", ", result));

            Console.Write("Greater the 5: ");
            result = from d in data
                     where d > 5
                     select d;
            Console.WriteLine(string.Join(", ", result));

            Console.Write("Greater the 5 in descending: ");
            result = from d in data
                     where d > 5
                     orderby d descending
                     select d;
            Console.WriteLine(string.Join(", ", result));

            Console.Write("Press a key to exit ... ");
            Console.ReadKey();
        }
    }
}
