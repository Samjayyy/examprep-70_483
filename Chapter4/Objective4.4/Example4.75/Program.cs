using System;
using System.Runtime.Serialization;

namespace Example4._75
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    [Serializable]
    public class Person
    {
        public int ID { get; set; }

        public string Name { get; set; }

        [NonSerialized]
        private bool isDirty = false;

        [OnSerializing()]
        internal void OnSerializingMethod(StreamingContext context)
        {
            Console.WriteLine("Serializing");
        }

        [OnSerialized()]
        internal void OnSerializedMethod(StreamingContext context)
        {
            Console.WriteLine("OnSerialized");
        }

        [OnDeserializing()]
        internal void OnDeserializingMethod(StreamingContext context)
        {
            Console.WriteLine("OnDeserializing");
        }

        [OnDeserialized()]
        internal void OnDeserializedMethod(StreamingContext context)
        {
            Console.WriteLine("OnDeserialized");
        }
    }
}
