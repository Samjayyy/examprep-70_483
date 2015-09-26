using System.Collections;
using System.Collections.Generic;

namespace Example2._56
{
    class Program
    {
        static void Main(string[] args)
        {
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
