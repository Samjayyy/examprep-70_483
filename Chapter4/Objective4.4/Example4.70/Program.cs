using System;
using System.IO;
using System.Xml.Serialization;

namespace Example4._70
{
    class Program
    {
        static void Main(string[] args)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(Person));
            string xml;
            using (StringWriter stringWriter = new StringWriter())
            {
                Person p = new Person()
                {
                    FirstName = "John",
                    LastName = "Doe",
                    Age = 42
                };
                serializer.Serialize(stringWriter, p);
                xml = stringWriter.ToString();
            }

            Console.WriteLine(xml);
            Console.WriteLine("");

            using (StringReader stringReader = new StringReader(xml))
            {
                Person p = (Person)serializer.Deserialize(stringReader);
                Console.WriteLine("{0} {1} is {2} years old", p.FirstName, p.LastName, p.Age);
            }

            Console.Write("Press a key to exit ... ");
            Console.ReadKey();
        }
    }

    [Serializable]
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
    }
}
