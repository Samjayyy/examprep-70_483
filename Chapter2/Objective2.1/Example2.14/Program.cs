
using System;

namespace Example2._14
{
    class Program
    {
        static void Main(string[] args)
        {
            var wrapped = new MyClass<DummyClass>();
            wrapped.MyProperty.Value = 1;
            Console.WriteLine($"val: {wrapped.MyProperty.Value}");
            Console.ReadKey();
        }
    }

    class MyClass<T> where T : class, new()
    {
        public MyClass()
        {
            MyProperty = new T();
        }

        public T MyProperty { get; set; }
    }

    class DummyClass
    {
        public int Value;
    }
}
