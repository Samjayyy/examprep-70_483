using System;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;

namespace Example4._79
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person
            {
                Id = 1,
                Name = "John Doe"
            };

            using (MemoryStream stream = new MemoryStream())
            {
                DataContractJsonSerializer ser = new DataContractJsonSerializer(typeof(Person));
                ser.WriteObject(stream, p);

                stream.Position = 0;
                StreamReader streamReader = new StreamReader(stream);
                Console.WriteLine("Serialized JSON: {0}",streamReader.ReadToEnd());

                stream.Position = 0;
                Person result = (Person)ser.ReadObject(stream);
            }

            Console.Write("Press a key to exit ... ");
            Console.ReadKey();
        }
    }

    [DataContract]
    public class Person
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string Name { get; set; }
    }
}
