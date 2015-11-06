using System;
using System.Linq;
using System.Threading;

namespace Example_09
{
    class Program
    {
        static void Main()
        {
            ThreadPool.QueueUserWorkItem(s => {
                foreach (var i in Enumerable.Range(0, 20)) {
                    Console.WriteLine("Helper Thread ({0}): {1}", Thread.CurrentThread.ManagedThreadId, i);
                    Thread.Sleep(0);
                }
            });

            Console.ReadLine();
        }
    }
}