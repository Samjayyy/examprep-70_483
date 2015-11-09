using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example4._50
{
    class Program
    {
        public class Person
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }
        }

        static void Main(string[] args)
        {
            Person p1 = new Person();
            p1.FirstName = "John";
            p1.LastName = "Doe";

            Console.WriteLine("Person 1: {0} {1}", p1.FirstName, p1.LastName);

            Person p2 = new Person {
                FirstName = "Jane",
                LastName = "Doe"
            };

            Console.WriteLine("Person 2: {0} {1}", p2.FirstName, p2.LastName);

            var people = new List<Person>()
            {
                new Person
                {
                    FirstName = "Lisa",
                    LastName = "Simpson"
                },
                new Person
                {
                    FirstName = "Bart",
                    LastName = "Simpson"
                }
            };

            foreach (var person in people)
            {
                Console.WriteLine("Person: {0} {1}", person.FirstName, person.LastName);
            }

            Console.Write("Press a key to exit ... ");
            Console.ReadKey();
        }
    }
}
