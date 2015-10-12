using System;
using System.Threading;
using System.Threading.Tasks;

namespace Example_25
{
    internal class Program
    {
        private static void Main()
        {
            var n = 0;
//            var @lock = new object();
            var up = Task.Run(() => {
                for (var i = 0; i < 1E6; i++) {
//                    lock (@lock) {
                        n++;
//                    }
//                    Interlocked.Increment(ref n);
                }
            });
            var down = Task.Run(() => {
                for (var i = 0; i < 1E6; i++) {
//                    lock (@lock) {
                        n--;
//                    }
//                    Interlocked.Decrement(ref n);
                }
            });

            Task.WaitAll(up, down);
            Console.WriteLine(n);
            Console.ReadLine();
        }
    }
}