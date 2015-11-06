using System;
using System.Collections.Concurrent;

namespace Example_22
{
    internal class Program
    {
        private static void Main()
        {
            var stack = new ConcurrentStack<int>();
            stack.Push(42);

            int result;
            if (stack.TryPop(out result)) {
                Console.WriteLine(result);
            }

            stack.PushRange(new[] {1, 2, 3});
            var values = new int[2];
            stack.TryPopRange(values);

            foreach (var i in values) {
                Console.WriteLine(i);
            }

            Console.ReadLine();
        }
    }
}