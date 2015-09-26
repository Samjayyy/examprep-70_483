
using System;

namespace Example2._32
{
    class Program
    {
        static void Main(string[] args)
        {
            var test = new Accessibility("initial value");

            Console.WriteLine(test.MyProperty);
            Console.ReadKey();
        }
    }

    public class Accessibility
    {
        private string _myField;

        public Accessibility(string myField)
        {
            _myField = myField;
        }

        public string MyProperty
        {
            get { return _myField; }
            set { _myField = value; }
        }
    }
}
