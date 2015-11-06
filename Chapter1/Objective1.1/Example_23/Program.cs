using System;
using System.Collections.Concurrent;

namespace Example_23
{
    internal class Program
    {
        private static void Main()
        {
            var queue = new ConcurrentQueue<int>();
            queue.Enqueue(42);

            int result;
            if (queue.TryDequeue(out result)) {
                Console.WriteLine("Dequeued: {0}", result);
            }

            Console.ReadLine();
        }
    }
}