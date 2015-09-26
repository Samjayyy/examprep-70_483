using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example3._22
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    class Set<T>
    {
        private List<T>[] buckets = new List<T>[100];

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
