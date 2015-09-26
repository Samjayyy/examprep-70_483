using System;
using System.Collections.Concurrent;
using System.Threading.Tasks;

namespace Example1._29
{
    class Program
    {
        static void Main(string[] args)
        {
            BlockingCollection<string> col = new BlockingCollection<string>();
            Task read = Task.Run(() =>
            {
                foreach (var v in col.GetConsumingEnumerable())
                {
                    Console.WriteLine(v);
                }
            });
            Console.WriteLine("Enter white space to break");
            Task write = Task.Run(() =>
            {
                while (true)
                {
                    string s = Console.ReadLine();
                    if (string.IsNullOrWhiteSpace(s))
                    {
                        break;
                    }

                    col.Add(s);
                }
            });
            write.Wait();

            Console.Write("Press a key to exit");
            Console.ReadKey();
        }
    }
}
