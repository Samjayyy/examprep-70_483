using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Example1._15
{
    class Program
    {
        static void Main(string[] args)
        {
            Task<int>[] tasks = new Task<int>[3];

            tasks[0] = Task.Run(() =>
                {
                    Thread.Sleep(1000); 

                    return 1;
                });

            tasks[1] = Task.Run(() =>
            {
                Thread.Sleep(1000);

                return 2;
            });

            tasks[2] = Task.Run(() =>
            {
                Thread.Sleep(1000);

                return 3;
            });

            while (tasks.Length > 0)
            {
                var i = Task.WaitAny(tasks);

                var completedTask = tasks[i];

                Console.WriteLine(completedTask.Result);

                var temp = tasks.ToList();
                temp.RemoveAt(i);
                tasks = temp.ToArray();
            }

            Console.Write("Press a key to exit");
            Console.ReadKey();
        }
    }
}
