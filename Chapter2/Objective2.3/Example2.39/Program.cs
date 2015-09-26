
using System;

namespace Example2._39
{
    class Program
    {
        static void Main(string[] args)
        {
            IInterfaceA impl = new Implementation();

            impl.MyMethod();
            Console.ReadKey();
        }
    }

    interface IInterfaceA
    { 
        void MyMethod();
    }

    class Implementation : IInterfaceA
    {
        void IInterfaceA.MyMethod() {
            Console.WriteLine("Call me on the interface");
        }
    }
}
