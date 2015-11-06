using System;
using System.Linq;
using System.Threading;

namespace Example_04
{
    class Program
    {
        static void Main()
        {
            var thread = new Thread(() => {
                foreach (var i in Enumerable.Range(0, 30)) {
                    Console.WriteLine("Helper Thread ({0}): {1}", Thread.CurrentThread.ManagedThreadId, i);
                    Thread.Sleep(0);
                }
            });

            thread.Priority = ThreadPriority.AboveNormal;
            thread.Start();
            foreach (var i in Enumerable.Range(0, 30)) {
                Console.WriteLine("Main Thread ({0}): {1}", Thread.CurrentThread.ManagedThreadId, i);
                Thread.Sleep(0);
            }

            Console.ReadLine();
        }
    }
}