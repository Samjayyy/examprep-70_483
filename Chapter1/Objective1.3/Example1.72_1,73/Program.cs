using System.Collections.Generic;

namespace Example1._72
{
    class Program
    {
        static void Main(string[] args)
        {
        }

        private static void CannotChangeForeachIterationVariable()
        {
            var people = new List<Person>
            {
                new Person() { FirstName = "John", LastName = "Doe"},
                new Person() { FirstName = "Jane", LastName = "Doe"},
            };
            foreach (Person p in people)
            {
                p.LastName = "Changed"; // This is allowed
                // p = new Person(); // This gives a compile error
            }

            // Compiler generated code
            List<Person>.Enumerator e = people.GetEnumerator();
            try
            {
                Person v;
                while (e.MoveNext())
                {
                    v = e.Current;
                }
            }
            finally
            {
                System.IDisposable d = e as System.IDisposable;
                if (d != null) d.Dispose();
            }
        }
    }

    private class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
