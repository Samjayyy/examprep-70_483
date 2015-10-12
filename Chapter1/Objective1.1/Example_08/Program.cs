using System;
using System.Threading;

namespace Example_08
{
    class Program
    {
        static readonly ThreadLocal<int> Field = new ThreadLocal<int>(InitializeField);

//      Similar to
//        [ThreadStatic]
//        static readonly Lazy<int> Field = new Lazy<int>(InitializeField);


        static int InitializeField()
        {
            return Thread.CurrentThread.ManagedThreadId;
        }

        private static void Main()
        {
            var thread = new Thread(() => {
                for (var i = 0; i < Field.Value; i++) {
                    Console.WriteLine("Thread {0}: {1}", Thread.CurrentThread.ManagedThreadId, i);
                    Thread.Sleep(0);
                }
            });

            thread.Start();
            var anotherThread = new Thread(() => {
                for (var i = 0; i < Field.Value; i++) {
                    Console.WriteLine("Thread {0}: {1}", Thread.CurrentThread.ManagedThreadId, i);
                    Thread.Sleep(0);
                }
            });
            anotherThread.Start();

            Console.ReadLine();
        }
    }
}