using System;
using System.Threading;
using System.Threading.Tasks;

namespace Example_26
{
    internal class Program
    {
        private static void Main()
        {
            var lockA = new object();
            var lockB = new object();

            var up = Task.Run(() => {
                lock (lockA) {
                    Thread.Sleep(3000);
                    lock (lockB) {
                        Console.WriteLine("Locked A and B");
                    }
                }
            });

            lock (lockB) {
                lock (lockA) {
                    Console.WriteLine("Locked A and B");
                }
            }
            up.Wait();

            Console.ReadLine();

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