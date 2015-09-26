using System;
using System.Threading;
using System.Threading.Tasks;

namespace Example1._44
{
    class Program
    {
        static void Main(string[] args)
        {
            CancellationTokenSource cancellationTokenSource = new CancellationTokenSource();
            CancellationToken token = cancellationTokenSource.Token;

            Task task = Task.Run(() =>
            {
                while (!token.IsCancellationRequested)
                {
                    Console.Write("*");
                    Thread.Sleep(100);
                }

                token.ThrowIfCancellationRequested();
            }, token).ContinueWith((t) =>
                {
                    t.Exception.Handle((e) => true);
                    Console.WriteLine("You have cancled the task");
                }, TaskContinuationOptions.OnlyOnCanceled);

            Console.WriteLine("Press enter to stop the task");
            Console.ReadLine();
            cancellationTokenSource.Cancel();
            Console.WriteLine("Press enter to end the application");
            Console.ReadLine();
        }
    }
}
