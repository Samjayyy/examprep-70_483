using System;
using System.Diagnostics;

namespace Example3._41
{
    class Program
    {
        static void Main(string[] args)
        {
            SomeMethod();

            // Add a breakpoint and hover the person field with the mouse to see the DebuggerDisplay values.
            var person = new Person("John", "Doe");

            Console.WriteLine("Press a key to exit");
            Console.ReadKey();
        }

        public static void SomeMethod()
        {
#if DEBUG
            Log("Log");
#endif
            Log2("Log2");
        }

        private static void Log(string message)
        {
            Console.WriteLine(message);
        }

        // More convenient way of wrapping a method

        [Conditional("DEBUG")]
        private static void Log2(string message)
        {
            Console.WriteLine(message);
        }

        [DebuggerDisplay("Name = {FirstName} {LastName}")]
        public class Person
        {
            public string FirstName { get; set; }

            public string LastName { get; set; }

            public Person(string firstName, string lastName)
            {
                this.FirstName = firstName;
                this.LastName = lastName;
            }
        }
    }
}
