
using System;

namespace Example2._7
{
    class Program
    {
        static void Main(string[] args)
        {
            CallingMethod();
            Console.ReadKey();
        }

        private static void MyMethod(int firstArgument, string secondArgument = "default value", bool thirdArgument = false)
        {
            Console.WriteLine($"{firstArgument} {secondArgument} {thirdArgument}");
        }

        private static void CallingMethod()
        {
            MyMethod(1, thirdArgument: true);
            MyMethod(2, "test");
            MyMethod(3);
            MyMethod(firstArgument: 4, thirdArgument: false, secondArgument: "second");
        }
    }
}
