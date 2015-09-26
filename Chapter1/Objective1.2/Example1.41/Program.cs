using System;
using System.Threading;
using System.Threading.Tasks;

namespace Example1._41
{
    class Program
    {
        private static  int value = 2;

        static void Main(string[] args)
        {
            Task t1 = Task.Run(() =>
            {
                if (value == 1)
                {
                    // Removing the following line will change the output
                    Thread.Sleep(1000);
                    value = 2;
                }
            });

            Task t2 = Task.Run(() =>
                {
                    value = 3;

                    // This way the value will be changed to 3
                    //Interlocked.CompareExchange(ref value, 3, 2);
                });

            Task.WaitAll(t1, t2);
            Console.WriteLine(value); // Displays 2
            Console.Write("Press a key to exit");
            Console.ReadKey();
        }
    }
}
