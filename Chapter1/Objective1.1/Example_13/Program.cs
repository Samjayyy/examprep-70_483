using System;
using System.Threading.Tasks;

namespace Example_13
{
    internal class Program
    {
        /// <summary>
        /// THIS EXAMPLE IS EQUALLY BROKEN!
        /// </summary>
        private static void Main()
        {
            var parent = Task.Run(() => {
                var results = new int[3];
                var tf = new TaskFactory(TaskCreationOptions.AttachedToParent,
                    TaskContinuationOptions.ExecuteSynchronously);
                tf.StartNew(() => results[0] = 0);
                tf.StartNew(() => results[1] = 1);
                tf.StartNew(() => results[2] = 2);

                return results;
            });

            var finalTask = parent.ContinueWith(parentTask => {
                foreach (var i in parentTask.Result) {
                    Console.WriteLine(i);
                }
            });

            finalTask.Wait();
            Console.ReadKey();
        }
    }
}