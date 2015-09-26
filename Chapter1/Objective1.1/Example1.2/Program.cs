using System;
using System.Threading;

namespace Example1._2
{
    public static class Program
    {
        public static void ThreadMethod()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("ThreadProc: {0}", i);
                Thread.Sleep(1000);
            }

            Console.Write("Press a key to exit");
            Console.ReadKey();
        }

        public static void Main()
        {
            Thread thread = new Thread(new ThreadStart(ThreadMethod));
            thread.Start();
            thread.IsBackground = true;
        }
    }
}
