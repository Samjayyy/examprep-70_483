using System;

namespace Example2._37
{
    class Program
    {
        static void Main(string[] args)
        {
            var person = new Person();
            person.FirstName = "Sam";

            Console.WriteLine($"Person: {person.FirstName}");
            Console.ReadKey();
        }
    }

    class Person
    {
        private string _firstName;

        public string FirstName
        {
            get { return _firstName; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Firstname can't be empty");
                }

                _firstName = value;
            }
        }

        public int Number { get; set; }
    }
}
