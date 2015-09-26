using System;

namespace Example2._48
{
    class Program
    {
        static void Main(string[] args)
        {
            Base b = new Base();
            b.Execute();
            b = new Derived();
            b.Execute();

            Console.Write("Press a key to exit");
            Console.ReadKey();
        }
    }

    class Base
    {
        public void Execute() { Console.WriteLine("Base.Execute"); }
    }

    class Derived : Base
    {
        public new void Execute() { Console.WriteLine("Derived.Execute"); }
    }
}
