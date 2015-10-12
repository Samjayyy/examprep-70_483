using System;
using System.Linq;
using System.Threading;

namespace Example_01
{
    class Program
    {
        static void Main()
        {
            var thread = new Thread(() => {
                foreach (var i in Enumerable.Range(0, 30)) {
                    Console.WriteLine("Helper Thread ({0}): {1}", Thread.CurrentThread.ManagedThreadId, i);
                }
            });

            thread.Start();
            foreach (var i in Enumerable.Range(0, 30)) {
                Console.WriteLine("Main Thread ({0}): {1}", Thread.CurrentThread.ManagedThreadId, i);
            }

            Console.ReadLine();
        }
    }
}