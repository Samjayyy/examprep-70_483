using System;

namespace Example1._75
{
    class Program
    {
        public delegate int Calculate(int x, int y);

        public static int Add(int x, int y) { return x + y; }
        public static int Multiply(int x, int y) { return x * y; }

        static void Main(string[] args)
        {
            UseDelegate();

            Console.Write("Press a key to exit");
            Console.ReadKey();
        }

        public static void UseDelegate() 
        {
            Calculate calc = Add;
            Console.WriteLine("calc = this.Add: {0}", calc(3, 4));

            calc = Multiply;
            Console.WriteLine("calc = this.Multiply: {0}", calc(3, 4));
        }
    }
}
