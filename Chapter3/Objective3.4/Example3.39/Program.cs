using System;

namespace Example3._39
{
    class Program
    {
        static void Main(string[] args)
        {
#pragma warning disable
            while (false)
            {
                Console.WriteLine("Unreachable code");
            }
#pragma warning restore



#pragma warning disable 0162, 0168
            int i;
            // Restoring warning for 'Unreachable code'
#pragma warning restore 0162
            while (false)
            {
                Console.WriteLine("Unreachable code");
            }
#pragma warning restore
        }
    }
}
