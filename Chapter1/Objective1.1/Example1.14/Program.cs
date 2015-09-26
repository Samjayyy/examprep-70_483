using System;
using System.Threading;
using System.Threading.Tasks;

namespace Example1._14
{
    class Program
    {
        static void Main(string[] args)
        {
            Task[] tasks = new Task[3];

            tasks[0] = Task.Run(() =>
                {
                    Thread.Sleep(1000);

                    Console.WriteLine("1");

                    return 1;
                });

            tasks[1] = Task.Run(() =>
            {
                Thread.Sleep(1000);

                Console.WriteLine("2");

                return 2;
            });

            tasks[2] = Task.Run(() =>
            {
                Thread.Sleep(1000);

                Console.WriteLine("3");

                return 3;
            });

            Task.WaitAll();
            Console.Write("Press a key to exit");
            Console.ReadKey();
        }
    }
}
