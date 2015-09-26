using System;
using System.Collections.Concurrent;

namespace Example1._32
{
    class Program
    {
        static void Main(string[] args)
        {
            ConcurrentStack<int> stack = new ConcurrentStack<int>();

            stack.Push(42);

            int result;
            if (stack.TryPop(out result))
            {
                Console.WriteLine(result);
            }

            stack.PushRange(new int[] { 1, 2, 3 });

            int[] values = new int[2];
            stack.TryPopRange(values);

            foreach (var i in values)
            {
                Console.WriteLine(i);
            }

            Console.Write("Press a key to exit");
            Console.ReadKey();
        }
    }
}
