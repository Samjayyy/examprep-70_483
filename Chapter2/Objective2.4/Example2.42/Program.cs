
namespace Example2._42
{
    class Program
    {
        static void Main(string[] args)
        {
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
