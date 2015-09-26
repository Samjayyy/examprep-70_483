using System;
using System.IO;
using System.Runtime.Serialization;

namespace Example4._77
{
    class Program
    {
        static void Main(string[] args)
        {
            var path = "data.xml";
            InitializeFile(path);

            Person p = new Person
            {
                Id = 1,
                Name = "John Doe"
            };

            using (Stream stream = new FileStream(path, FileMode.Open))
            {
                DataContractSerializer ser = new DataContractSerializer(typeof(Person));
                ser.WriteObject(stream, p);
                Console.WriteLine("Serialized ...");
            }

            using (Stream stream = new FileStream(path, FileMode.Open))
            {
                DataContractSerializer ser = new DataContractSerializer(typeof(Person));
                Person result = (Person)ser.ReadObject(stream);
                Console.WriteLine("Deserialize ...");
            }

            Console.Write("Press a key to exit ... ");
            Console.ReadKey();
        }

        private static void InitializeFile(string path)
        {
            if (File.Exists(path))
            {
                File.Delete(path);
                Console.WriteLine("{0} deleted", path);
            }

            File.Create(path).Close();
            Console.WriteLine("{0} created", path);
        }
    }

    [DataContract]
    public class Person
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string Name { get; set; }

        private bool isDirty = false;
    }
}
