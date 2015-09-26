using System;
using System.Threading;
using System.Threading.Tasks;

namespace Example1._37
{
    class Program
    {
        static void Main(string[] args)
        {
            object lockA = new object();
            object lockB = new object();

            var up = Task.Run(() =>
            {
                lock (lockA)
                {
                    Thread.Sleep(1000);
                    lock (lockB)
                    {
                        Console.WriteLine("Locked A and B");
                    }
                }
            });

            lock (lockB)
            {
                lock (lockA)
                {
                    Console.WriteLine("Locked A and B");
                }
            }

            up.Wait();

            Console.Write("Press a key to exit");
            Console.ReadKey();

            //// Generated code from the lock statement
            //object gate = new object();
            //bool __LockTaken = false;
            //try
            //{
            //    Monitor.Enter(gate, ref __LockTaken);
            //}
            //finally
            //{
            //    if ((__LockTaken))
            //    {
            //        Monitor.Exit(gate);
            //    }
            //}
        }
    }
}
