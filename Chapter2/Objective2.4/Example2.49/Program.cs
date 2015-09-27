
using System;

namespace Example2._49
{
    class Program
    {
        static void Main(string[] args)
        {
            Base b = new Derived();

            b.MethodWithImplementation();

            Console.ReadKey();

        }
    }

    abstract class Base
    {
        public virtual void MethodWithImplementation() {
            Console.WriteLine("MethodWithImplementation");
            AbstractMethod();
        }

        public abstract void AbstractMethod();
    }

    class Derived : Base
    {
        public override void AbstractMethod() {
            Console.WriteLine("Implementation of abstract method");
        }
    }
}
