using System;
using System.Collections.Generic;
using System.Text;

namespace Example4._90
{
    class Program
    {
        static void Main(string[] args)
        {
            PeopleCollection pc = new PeopleCollection() { new Person() { Age = 22, FirstName = "Janne", LastName = "Doe" } };
            pc.Add(new Person() { Age = 21, LastName = "Doe", FirstName = "John" });

            Console.WriteLine("Count: {0}, Contents: {1}", pc.Count, pc.ToString());
            Console.WriteLine("Removing persons with 21 age...");
            pc.RemoveByAge(21);
            Console.WriteLine("Count: {0}, Contents: {1}", pc.Count, pc.ToString());

            Console.Write("Press a key to exit ... ");
            Console.ReadKey();
        }
    }

    public class Person
    {
        public int Age { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }
    }

    public class PeopleCollection : List<Person>
    {
        public void RemoveByAge(int age)
        {
            for (int index = this.Count - 1; index >= 0; index--)
            {
                if (this[index].Age == age)
                {
                    this.RemoveAt(index);
                }
            }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            foreach (Person p in this)
            {
                sb.AppendFormat("{0} {1} is {2}; ", p.FirstName, p.LastName, p.Age);
            }

            return sb.ToString();
        }
    }
}
