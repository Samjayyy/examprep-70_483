using System;
using System.Linq;
using System.Threading;

namespace Example_03
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

            thread.Start();
            foreach (var i in Enumerable.Range(0, 10)) {
                Console.WriteLine("Main Thread ({0}): {1}", Thread.CurrentThread.ManagedThreadId, i);
                Thread.Sleep(0);
            }

            Console.WriteLine("Main Thread starts waiting...");
            // This blocks the Main Thread until the Helper Thread is done.
            thread.Join();
            Console.WriteLine("Helper Thread joined.");
            Console.ReadLine();
        }
    }
}