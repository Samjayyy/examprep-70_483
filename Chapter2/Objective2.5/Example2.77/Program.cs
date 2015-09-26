using System;

namespace Example2._77
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<int, int, int> addFunc = (x, y) => x + y;
            Console.WriteLine(string.Format("2 + 3 = {0}", addFunc(2, 3)));

            Console.Write("Press a key to exit");
            Console.ReadKey();
        }
    }
}
