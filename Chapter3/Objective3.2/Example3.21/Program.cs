using System;
using System.Collections.Generic;
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

            Console.WriteLine("Press a key to exit");
            Console.ReadKey();
        }
    }

    class Set<T>
    {
        private List<T> list = new List<T>();

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
