using System;
using System.Globalization;
using System.IO;
using System.Xml;

namespace Example2._89
{
    class Program
    {
        static void Main(string[] args)
        {
            var stringWriter = new StringWriter();
            using (XmlWriter writer = XmlWriter.Create(stringWriter))
            {
                writer.WriteStartElement("book");
                writer.WriteElementString("price", "19.95");
                writer.WriteEndElement();
                writer.Flush();
            }
            string xml = stringWriter.ToString();
            Console.WriteLine(xml);
            Console.WriteLine("-------");

            var stringReader = new StringReader(xml);
            using (XmlReader reader = XmlReader.Create(stringReader))
            {
                reader.ReadToFollowing("price");
                decimal price = decimal.Parse(reader.ReadInnerXml(), new CultureInfo("en-US"));
                Console.WriteLine(string.Format("Price read from xml is: {0}", price));
            }

            Console.Write("Press a key to exit");
            Console.ReadKey();
        }
    }
}
