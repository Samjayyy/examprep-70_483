using System;
using System.Threading.Tasks;

namespace Example1._12
{
    class Program
    {
        static void Main(string[] args)
        {
            Task<Int32[]> parent = Task.Run(() =>
                {
                    var results = new Int32[3];
                    new Task(() => results[0] = 0,
                        TaskCreationOptions.AttachedToParent).Start();
                    new Task(() => results[1] = 1,
                        TaskCreationOptions.AttachedToParent).Start();
                    new Task(() => results[2] = 2,
                        TaskCreationOptions.AttachedToParent).Start();

                    return results;
                });

            var finalTask = parent.ContinueWith(
                parentTask =>
                {
                    foreach (int i in parentTask.Result)
                    {
                        Console.WriteLine(i);
                    }
                });

            finalTask.Wait();
            Console.Write("Press a key to exit");
            Console.ReadKey();
        }
    }
}
