
using System;

namespace Example2._33
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
        // initialization code and error checking omitted
        private string[] _myField;

        public Accessibility(string myField)
        {
            _myField = new string[1];
            // ...
            _myField[0] = myField;
        }

        public string MyProperty
        {
            get { return _myField[0]; }
            set { _myField[0] = value; }
        }
    }
}
