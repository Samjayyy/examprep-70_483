using System;
using System.Collections.Generic;

namespace Example4._63
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] data = { 1, 2, 5, 8, 11 };
            var result = data.Where(d => d > 5);
            Console.WriteLine(string.Join(", ", result));

            Console.Write("Press a key to exit ... ");
            Console.ReadKey();
        }
    }

    public static class LinqExtensions
    {
        public static IEnumerable<TSource> Where<TSource>(this IEnumerable<TSource> source, Func<TSource, bool> predicate)
        {
            foreach (TSource item in source)
            {
                if (predicate(item))
                {
                    yield return item;
                }
            }
        }
    }
}
