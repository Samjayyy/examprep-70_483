using System;
using System.Collections.Concurrent;

namespace Example_24
{
    internal class Program
    {
        private static void Main()
        {
            var dictionary = new ConcurrentDictionary<string, int>();
            if (dictionary.TryAdd("k1", 42)) {
                Console.WriteLine("Added 42");
            }

            // Overwrite conditionally
            if (dictionary.TryUpdate("k1", 21, 42)) {
                Console.WriteLine("42 updated to 21");
            }
            //Overwrite unconditionally
            dictionary["k1"] = 42;

            var r1 = dictionary.AddOrUpdate("k1", 3, (s, i) => i * 2);
            var r2 = dictionary.GetOrAdd("k2", 3);

            Console.ReadLine();
        }
    }
}
