using System;
using System.Threading;
using System.Threading.Tasks;

namespace Example1._45
{
    class Program
    {
        static void Main(string[] args)
        {
            Task longRunning = Task.Run(() =>
                {
                    Thread.Sleep(10000);
                });

            int index = Task.WaitAny(new[] { longRunning }, 1000);
            if (index == -1)
            {
                Console.WriteLine("Task timed out");
            }

            Console.Write("Press a key to exit");
            Console.ReadKey();
        }
    }
}
