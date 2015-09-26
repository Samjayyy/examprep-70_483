using System;
using System.Threading;

namespace Example1._6
{
    public static class Program
    {
        public static ThreadLocal<int> field = new ThreadLocal<int>(() =>
            {
                return Thread.CurrentThread.ManagedThreadId;
            });

        public static void Main()
        {
            new Thread(() =>
            {
                for (int i = 0; i < field.Value; i++)
                {
                    Console.WriteLine("Thread A: {0}", i);
                }
            }).Start();
            new Thread(() =>
            {
                for (int i = 0; i < field.Value; i++)
                {
                    Console.WriteLine("Thread B: {0}", i);
                }
            }).Start();
            Console.Write("Press a key to exit");
            Console.ReadKey();
        }
    }
}
