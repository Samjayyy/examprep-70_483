using System;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Security.Permissions;

namespace Example4._76
{
    class Program
    {
        static void Main(string[] args)
        {
            var path = "data.bin";
            InitializeFile(path);

            PersonComplex p = new PersonComplex
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
                PersonComplex dp = (PersonComplex)formatter.Deserialize(stream);
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
    public class PersonComplex : ISerializable
    {
        public int Id { get; set; }
        public string Name { get; set; }
        private bool isDirty = false;

        public PersonComplex()
        { }

        protected PersonComplex(SerializationInfo info, StreamingContext context)
        {
            this.Id = info.GetInt32("Value1");
            this.Name = info.GetString("Value2");
            this.isDirty = info.GetBoolean("Value3");
        }

        [SecurityPermission(System.Security.Permissions.SecurityAction.Demand, SerializationFormatter = true)]
        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("Value1", Id);
            info.AddValue("Value2", Name);
            info.AddValue("Value3", isDirty);
        }
    }

}
