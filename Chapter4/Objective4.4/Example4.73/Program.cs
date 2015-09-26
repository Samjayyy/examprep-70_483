using System;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace Example4._73
{
    class Program
    {
        static void Main(string[] args)
        {
            var path = "data.bin";
            InitializeFile(path);

            Person p = new Person
            {
                Id = 1,
                Name = "John Doe"
            };

            IFormatter formatter = new BinaryFormatter();
            using (Stream stream = new FileStream(path, FileMode.Open))
            {
                formatter.Serialize(stream, p);
                Console.WriteLine("Serialized ...");
            }

            using (Stream stream = new FileStream(path, FileMode.Open))
            {
                Person dp = (Person)formatter.Deserialize(stream);
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

    [Serializable]
    public class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }

        [NonSerialized]
        private bool IsDirty = false;
    }
}
