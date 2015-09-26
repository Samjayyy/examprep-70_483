using System;
using System.Threading;

namespace Example1._3
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
            Thread thread = new Thread(new ParameterizedThreadStart(ThreadMethod));
            thread.Start(20);
            thread.Join();
        }
    }
}
