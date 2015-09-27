
using System;

namespace Example2._42
{
    class Program
    {
        static void Main(string[] args)
        {
            IReadOnlyInterface iexample = new ReadAndWriteImplementation();
            //iexample.Value = 1;
            Console.WriteLine(iexample.Value);

            var example = (ReadAndWriteImplementation)iexample;

            example.Value = 2;
            Console.WriteLine($"original {iexample.Value}");
            Console.WriteLine($"changed {example.Value}");

            Console.ReadKey();
        }
    }

    interface IReadOnlyInterface
    {
        int Value { get; }
    }

    struct ReadAndWriteImplementation : IReadOnlyInterface
    {
        public int Value { get; set; }
    }
}
