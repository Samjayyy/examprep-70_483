
using System;

namespace Example2._35
{
    class Program
    {
        static void Main(string[] args)
        {
            var c = new MyInternalClass();
            c.MyMethod();

            Console.ReadKey();
        }
    }

    internal class MyInternalClass
    {
        public void MyMethod() {
            Console.WriteLine("Can only be instantiated in the same assembly");
        }
    }

    public class MyPublicClass
    {
        public void MyMethod()
        {
            Console.WriteLine("Can be instantiated from other assemblies");
        }
    }

}
