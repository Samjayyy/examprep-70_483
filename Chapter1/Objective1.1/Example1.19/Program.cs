using System.Threading;
using System.Threading.Tasks;

namespace Example1._19
{
    class Program
    {
        static void Main(string[] args)
        {
        }

        // This method occupies a Thread from the thread pool while sleeping
        public Task SleepAsyncA(int millisecondsTimeout)
        {
            return Task.Run(() =>
                {
                    Thread.Sleep(millisecondsTimeout);
                });
        }

        // This method does not occupy a thread while waiting for the timer to run. This method gives scalability.
        public Task SleepAsyncB(int millisecondsTimeout)
        {
            TaskCompletionSource<bool> tcs = null;
            var t = new Timer(delegate { tcs.TrySetResult(true); }, null, -1, -1);
            tcs = new TaskCompletionSource<bool>(t);
            t.Change(millisecondsTimeout, -1);

            return tcs.Task;
        }
    }
}
