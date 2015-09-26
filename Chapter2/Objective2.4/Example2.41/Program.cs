using System;

namespace Example2._41
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    interface IExample
    {
        string GetResult();

        int Value { get; set; }

        event EventHandler ResultRetrieved;

        int this[string index] { get; set; }
    }

    class ExampleImplementation : IExample
    {
        public string GetResult()
        {
            return "result";
        }

        public int Value { get; set; }

        public event EventHandler CalculationPerformed;

        public event EventHandler ResultRetrieved;

        public int this[string index]
        {
            get
            {
                return 42;
            }
            set { }
        }
    }

}
