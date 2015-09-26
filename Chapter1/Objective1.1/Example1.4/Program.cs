using System;
using System.Threading;

namespace Example1._4
{
    public static class Program
    {
        public static void ThreadMethod(object o)
        {
            for (int i = 0; i < (int)o; i++)
            {
                Console.WriteLine("ThreadProc: {0}", i);
                Thread.Sleep(100);
            }

            Console.Write("Press a key to exit");
            Console.ReadKey();
        }

        public static void Main()
        {
            var stopped = false;
            Thread thread = new Thread(new ThreadStart(() =>
            {
                while (!stopped)
                {
                    Console.WriteLine("Running...");
                    Thread.Sleep(1000);
                }
            }));

            thread.Start();
            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
            stopped = true;
            thread.Join();
            thread.Join();
        }
    }
}
