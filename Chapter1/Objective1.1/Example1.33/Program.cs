using System;
using System.Collections.Concurrent;

namespace Example1._33
{
    class Program
    {
        static void Main(string[] args)
        {
            ConcurrentQueue<int> queue = new ConcurrentQueue<int>();
            queue.Enqueue(42);

            int result;
            if (queue.TryDequeue(out result))
            {
                Console.WriteLine("Dequeued: {0}", result);
            }

            Console.Write("Press a key to exit");
            Console.ReadKey();
        }
    }
}
