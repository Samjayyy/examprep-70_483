using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace Example3._22
{
    class Program
    {
        static void Main(string[] args)
        {
            TestPerformance();
            Console.ReadKey();
        }


        public static void TestPerformance()
        {
            Console.WriteLine("Test performance for objects");
            const int count = 15000;
            var numberSet = new Set<int>();
            var sw = Stopwatch.StartNew();
            // Add 2 times 15000 numbers
            Enumerable.Range(1, count).ToList().ForEach(numberSet.Insert);
            Enumerable.Range(1, count).ToList().ForEach(numberSet.Insert);
            sw.Stop();
            Console.WriteLine($"For {count} numbers: {sw.Elapsed}");
            Console.WriteLine($"Number of unique objects: {numberSet.Count}");
        }
    }

    class Set<T>
    {
        private List<T>[] buckets = new List<T>[100]; // play with number of buckets
        public int Count { get; private set; } = 0;

        public void Insert(T item)
        {
            int bucket = GetBucket(item.GetHashCode());
            if (Contains(item, bucket))
            {
                return;
            }

            if (buckets[bucket] == null)
            {
                buckets[bucket] = new List<T>();
            }
            buckets[bucket].Add(item);
            Count++;
        }

        private bool Contains(T item)
        {
            return Contains(item, GetBucket(item.GetHashCode()));
        }

        private int GetBucket(int hashcode)
        {
            // A Hash code can be negative. To make sure that you end up with a positive
            // value cast the value to an unsigned int. The unchecked block makes sure that
            // you can cast a value larger then int to an int safely.
            unchecked
            {
                return (int)((uint)hashcode % (uint)buckets.Length);
            }
        }

        private bool Contains(T item, int bucket)
        {
            if (buckets[bucket] != null)
            {
                foreach (T member in buckets[bucket])
                {
                    if (member.Equals(item))
                    {
                        return true;
                    }
                }
            }

            return false;
        }
    }
}
