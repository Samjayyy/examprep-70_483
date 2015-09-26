using System;

namespace Example2._96
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person("John", "Doe");
            Console.WriteLine(p);

            Console.Write("Press a key to exit");
            Console.ReadKey();
        }
    }

    class Person
    {
        public Person(string firstName, string lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }

        public override string ToString()
        {
            return this.FirstName + " " + this.LastName;
        }
    }
}
