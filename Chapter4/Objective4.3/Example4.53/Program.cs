using System;

namespace Example4._53
{
    class Program
    {
        static void Main(string[] args)
        {
            var person = new 
            {
                FirstName = "John",
                LastName = "Doe"
            };

            Console.WriteLine(person.GetType().Name);

            Console.Write("Press a key to exit ... ");
            Console.ReadKey();
        }
    }
}
