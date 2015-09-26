using System;
using System.Collections.Concurrent;

namespace Example1._34
{
    class Program
    {
        static void Main(string[] args)
        {
            var dict = new ConcurrentDictionary<string, int>();
            if (dict.TryAdd("k1", 42))
            {
                Console.WriteLine("Added");
            }

            if (dict.TryUpdate("k1", 21, 42))
            {
                Console.WriteLine("42 updated to 21");
            }

            dict["k1"] = 42; // Overwrite unconditinally

            int r1 = dict.AddOrUpdate("k1", 3, (s, i) => i * 2);
            int r2 = dict.GetOrAdd("k2", 3);

            Console.WriteLine("r1: {0}", r1);
            Console.WriteLine("r2: {0}", r2);

            Console.Write("Press a key to exit");
            Console.ReadKey();
        }
    }
}
