using System;

namespace Example2._41
{
    class Program
    {
        static void Main(string[] args)
        {
            IExample example = new ExampleImplementation();

            example.Value = 41;
            Console.WriteLine($"Value: {example.Value}");
            Console.WriteLine($"GetResult: {example.GetResult()}");
            Console.WriteLine($"indexer: {example["whatever"]}");
            Console.ReadKey();
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
