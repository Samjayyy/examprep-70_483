using System;
using System.Threading;
using System.Threading.Tasks;

namespace Example_17
{
    internal class Program
    {
        private static void Main()
        {
            var task = Run();
            task.Wait();
            Console.ReadLine();
        }

        public static async Task Run()
        {
            Console.WriteLine("I'm going to wait 5 seconds.");
            await TimeoutAsync(TimeSpan.FromSeconds(5));
            Console.WriteLine("I waited 5 seconds.");
            await TimeoutAsync(TimeSpan.FromSeconds(5));
            Console.WriteLine("I waited another 5 seconds.");
        }

        public static Task TimeoutAsync(TimeSpan timeout)
        {
            var tcs = new TaskCompletionSource<object>();
            new Timer(state => {
                tcs.SetResult(null);
            }, null, timeout, TimeSpan.FromMilliseconds(-1));
            return tcs.Task;
        }
    }
}