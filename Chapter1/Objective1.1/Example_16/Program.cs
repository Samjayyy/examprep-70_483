using System;
using System.Threading;

namespace Example_16
{
    internal class Program
    {
        // This looks like your typical JavaScript code, doesn't it?
        private static void Main()
        {
            Console.WriteLine("I'm going to wait 5 seconds.");
            TimeoutAsync(TimeSpan.FromSeconds(5), () => {
                Console.WriteLine("I waited 5 seconds.");
                TimeoutAsync(TimeSpan.FromSeconds(5), () => {
                    Console.WriteLine("I waited another 5 seconds.");
                });
            });
            Console.WriteLine("I can do other stuff in the meantime");
            Console.ReadLine();
        }

        // Some Asynchronous Method
        public static void TimeoutAsync(TimeSpan timeout, Action onTimeout)
        {
            Console.WriteLine("Waiting for timeout.");
            new Timer(state => onTimeout(), null, timeout, TimeSpan.FromMilliseconds(-1));
        }
    }
}