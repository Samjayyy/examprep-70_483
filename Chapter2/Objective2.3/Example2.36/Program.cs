
using System;

namespace Example2._36
{
    class Program
    {
        static void Main(string[] args)
        {
            var c = new MyClass();
            c.SetValue(36);

            Console.WriteLine($"val: {c.GetValue()}");
            Console.ReadKey();
        }
    }

    public class MyClass
    {
        private int _field;

        public void SetValue(int value) { _field = value; }

        public int GetValue() { return _field; }
    }
}
