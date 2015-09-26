using System;

namespace Example2._4
{
    class Program
    {
        static void Main(string[] args)
        {
            var calc = new Calculator();
            var result = calc.Add(1, 2);
            Console.WriteLine("calc.Add(1, 2) = {0}", result);

            Console.Write("Press a key to exit");
            Console.ReadKey();
        }
    }

    public class Calculator
    {
        public int Add(int x, int y)
        {
            return x + y;
        }
    }
}
