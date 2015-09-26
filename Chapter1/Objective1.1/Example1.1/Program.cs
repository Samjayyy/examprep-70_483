using System;
using System.Threading;

namespace Chapter1
{
    public static class Program
    {
        public static void ThreadMethod()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("ThreadProc: {0}", i);
                Thread.Sleep(0);
            }

            Console.Write("Press a key to exit");
            Console.ReadKey();
        }

        public static void Main()
        {
            Thread thread = new Thread(new ThreadStart(ThreadMethod));
            thread.Start();

            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine("Main thread: Do some work.");
                Thread.Sleep(0);
            }

            thread.Join();
        }
    }
}
