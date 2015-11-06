using System;
using System.Threading;

namespace Example_07
{
    class Program
    {
        //[ThreadStatic]
        static int field;

        static void Main()
        {
            var thread = new Thread(() => {
                for (var i = 0; i < 10; i++) {
                    field++;
                    Thread.Sleep(0);
                }
                Console.WriteLine("Last value of i on Helper Thread ({0}): {1}", Thread.CurrentThread.ManagedThreadId, field);
            });

            thread.Start();
            var anotherThread = new Thread(() => {
                for (var i = 0; i < 10; i++) {
                    field++;
                    Thread.Sleep(0);
                }
                Console.WriteLine("Last value of i on Helper Thread ({0}): {1}", Thread.CurrentThread.ManagedThreadId, field);
            });
            anotherThread.Start();

            Console.ReadLine();
        }
    }
}