using System;

namespace Example2._17
{
    class Program
    {
        static void Main(string[] args)
        {
            Base b = new Base();
            Console.WriteLine("Base.MyMethod(): {0}", b.MyMethod());
            Derived d = new Derived();
            Console.WriteLine("Derived.MyMethod(): {0}", d.MyMethod());

            Console.Write("Press a key to exit");
            Console.ReadKey();
        }
    }

    class Base
    {
        public virtual int MyMethod()
        {
            return 42;
        }
    }

    class Derived : Base
    {
        public override int MyMethod()
        {
            return base.MyMethod() * 2;
        }
    }
}
