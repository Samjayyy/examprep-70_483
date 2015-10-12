using System;
using System.Threading.Tasks;

namespace Example_12
{
    internal class Program
    {
        /// <summary>
        /// THIS EXAMPLE IS BROKEN!
        /// </summary>
        private static void Main()
        {
            var parent = Task.Run(() => {
                var results = new int[3];
                new Task(() => results[0] = 0,
                    TaskCreationOptions.AttachedToParent).Start();
                new Task(() => results[1] = 1,
                    TaskCreationOptions.AttachedToParent).Start();
                new Task(() => results[2] = 2,
                    TaskCreationOptions.AttachedToParent).Start();
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