using System;
using System.IO;
using System.Xml;

namespace Example4._44
{
    class Program
    {
        static void Main(string[] args)
        {
            StringWriter stream = new StringWriter();

            using (XmlWriter writer = XmlWriter.Create(stream, new XmlWriterSettings() { Indent = true }))
            {
                writer.WriteStartDocument();
                writer.WriteStartElement("People");
                writer.WriteStartElement("Person");
                writer.WriteAttributeString("firstName", "John");
                writer.WriteAttributeString("lastName", "Doe");
                writer.WriteStartElement("ContactDetails");
                writer.WriteElementString("EmailAddress", "john@unknown.com");
                writer.WriteEndElement();
                writer.WriteEndElement();
                writer.Flush();
            }

            Console.WriteLine("Strea: {0}", stream.ToString());

            Console.Write("Press a key to exit ... ");
            Console.ReadKey();
        }
    }
}
