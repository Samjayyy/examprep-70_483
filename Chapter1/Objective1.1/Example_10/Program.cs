using System;
using System.Threading.Tasks;

namespace Example_10
{
    internal class Program
    {
        private static void Main()
        {
            var task = Task.Run(() => {
                var sum = 0;
                for (var i = 0; i < 20; i++) {
                    sum += i;
                }
                return sum;
            });
            //            task.ContinueWith(t => {
            //                Console.WriteLine("Result: {0}", t.Result);
            //            });

            Console.WriteLine("Result: {0}", task.Result);
            Console.ReadLine();
        }
    }
}