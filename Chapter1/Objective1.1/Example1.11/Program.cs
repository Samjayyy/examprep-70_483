using System;
using System.Threading.Tasks;

namespace Example1._11
{
    class Program
    {
        static void Main(string[] args)
        {
            Task<int> t = Task.Run(() =>
                {
                    return 42;
                });

            t.ContinueWith((i) =>
                {
                    Console.WriteLine("Canceled");
                }, TaskContinuationOptions.OnlyOnCanceled);

            t.ContinueWith((i) =>
                {
                    Console.WriteLine("Faulted");
                }, TaskContinuationOptions.OnlyOnFaulted);

            var completedTask = t.ContinueWith((i) =>
                 {
                     Console.WriteLine("Completed");
                 }, TaskContinuationOptions.OnlyOnRanToCompletion);

            completedTask.Wait();
            Console.Write("Press a key to exit");
            Console.ReadKey();
        }
    }
}
