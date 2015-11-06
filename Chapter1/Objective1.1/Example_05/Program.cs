using System;
using System.Linq;
using System.Threading;

namespace Example_05
{
    class Program
    {
        static void Main()
        {
            var thread = new Thread(() => {
                foreach (var i in Enumerable.Range(0, 30)) {
                    try {
                        Console.WriteLine("Helper Thread ({0}): {1}", Thread.CurrentThread.ManagedThreadId, i);
                        Thread.Sleep(0);
                    } catch (ThreadAbortException) {
                        Console.WriteLine("Helper Thread was aborted.");
                    }
                }
            });

            thread.Start();
            foreach (var i in Enumerable.Range(0, 10)) {
                Console.WriteLine("Main Thread ({0}): {1}", Thread.CurrentThread.ManagedThreadId, i);
                Thread.Sleep(0);
            }

            thread.Abort();
            Console.ReadLine();
        }
    }
}