using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace Example3._21
{
    class Program
    {
        static void Main(string[] args)
        {
            Set<int> numberSet = new Set<int>();
            int value = 1;
            numberSet.Insert(value);
            Console.WriteLine("Insert: {0}", value);
            numberSet.Insert(value);
            Console.WriteLine("Insert: {0}", value);
            numberSet.Insert(value);
            Console.WriteLine("Insert: {0}", value);
            value++;
            numberSet.Insert(value);
            Console.WriteLine("Insert: {0}", value);

            Console.WriteLine("NumberSet contains: {0}", numberSet);
            Console.WriteLine("---------");
            Console.ReadKey();

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
        private List<T> list = new List<T>();
        public int Count { get { return list.Count; } }

        public void Insert(T item)
        {
            if (!Contains(item))
            {
                this.list.Add(item);
            }
        }

        private bool Contains(T item)
        {
            foreach (T member in this.list)
            {
                if (member.Equals(item))
                {
                    return true;
                }
            }

            return false;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            foreach (T member in this.list)
            {
                sb.Append(string.Format("{0} ", member.ToString()));
            }

            return sb.ToString();
        }
    }

}
