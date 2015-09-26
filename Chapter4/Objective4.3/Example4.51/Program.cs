using System;

namespace Example4._51
{
    class Program
    {
        static void Main(string[] args)
        {
            // With anonymous method
            Func<int, int> myDelegate = delegate(int x)
            {
                return x * 2;
            };
            Console.WriteLine("With anonymous method: {0}", myDelegate(21));

            // With lambda expression
            Func<int, int> myDelegateLambda = x => x * 2;
            Console.WriteLine("With lambda: {0}", myDelegateLambda(21));

            Console.Write("Press a key to exit ... ");
            Console.ReadKey();
        }
    }
}
