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

            Derived d = new Derived();
            d.Execute();

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
