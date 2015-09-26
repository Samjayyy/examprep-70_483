using System;
using System.Data.Entity;
using System.Linq;

namespace Example4._38
{
    class Program
    {
        static void Main(string[] args)
        {
            using (PeopleContext ctx = new PeopleContext())
            {
                ctx.People.Add(new Person() { Id = 1, Name = "John Doe" });
                ctx.SaveChanges();
            }

            using (PeopleContext ctx = new PeopleContext())
            {
                Person person = ctx.People.SingleOrDefault(p => p.Id == 1);
                Console.WriteLine("Retrived person from PeopleContext: {0}", person.Name);
            }
        }
    }

    public class Person
    {
        public int Id { get; set; }

        public string Name { get; set; }
    }

    public class PeopleContext : DbContext
    {
        public IDbSet<Person> People { get; set; }
    }
}
