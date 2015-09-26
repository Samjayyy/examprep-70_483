using System;
using System.Linq;

namespace Example1._76
{
    class Program
    {
        private delegate void Del();

        static void Main(string[] args)
        {
            Multicast();

            Console.Write("Press a key to exit");
            Console.ReadKey();
        }

        private static void Multicast()
        {
            Del d = MethodOne;
            d += MethodTwo;

            d();
            int invocationCount = d.GetInvocationList().Count();
            Console.WriteLine("d invocation count is: {0}", invocationCount);
        }

        private static void MethodOne()
        {
            Console.WriteLine("MethodOne");
        }

        private static void MethodTwo()
        {
            Console.WriteLine("MethodTwo");
        }
    }
}
