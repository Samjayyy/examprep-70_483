using System;
using System.Threading;

namespace Example1._7
{
    public static class Program
    {
        public static void Main()
        {
            ThreadPool.QueueUserWorkItem((s) =>
                {
                    Console.WriteLine("working on thread from threadpool.");
                });
            Console.WriteLine("Press a key to exit");
            Console.ReadKey();
        }
    }
}
