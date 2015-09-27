using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Example2._56
{
    class Program
    {
        static void Main(string[] args)
        {
            var persons = new Person[]
            {
                new Person("Samwise","The brave"),
                new Person("Frodo","Baggins"),
            };
            var people = new People(persons);

            Console.WriteLine("Using the enumerator");
            using (var enumerator = people.GetEnumerator())
            {
                while (enumerator.MoveNext())
                {
                    Console.WriteLine(enumerator.Current);
                }
            }

            Console.WriteLine("---------");
            Console.WriteLine("Using in foreach loop");
            foreach(var person in people)
            {
                Console.WriteLine(person);
            }

            Console.WriteLine("---------");
            Console.WriteLine("Directlt using LINQ statements");
            var foundName = people.Select(p => p.FirstName)
                    .FirstOrDefault(name => name.Contains("Sam"));
            Console.WriteLine($"Name containing Sam: {foundName}");


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
            return FirstName + " " + LastName;
        }
    }

    class People : IEnumerable<Person>
    {
        public People(Person[] people)
        {
            this.people = people;
        }

        private Person[] people;

        public IEnumerator<Person> GetEnumerator()
        {
            for (int index = 0; index < people.Length; index++)
            {
                yield return this.people[index];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }

}
