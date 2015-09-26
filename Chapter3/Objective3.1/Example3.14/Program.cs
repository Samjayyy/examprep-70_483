using System;
using System.Xml;
using System.Xml.Schema;

namespace Example3._14
{
    class Program
    {
        static void Main(string[] args)
        {
            // This will validate successfully. 
            // Try to remove the <FirstName>John</FirstName> row in Person.xml and restart the application.
            ValidateXML();

            Console.WriteLine("Press a key to exit");
            Console.ReadKey();
        }

        public static void ValidateXML()
        {
            string xsdPath = "Person.xsd";
            string xmlPath = "Person.xml";

            XmlReader reader = XmlReader.Create(xmlPath);
            XmlDocument document = new XmlDocument();
            document.Schemas.Add("", xsdPath);
            document.Load(reader);
            ValidationEventHandler eventHandler = new ValidationEventHandler(ValidationEventHandler);
            Console.WriteLine("Validating Person.xml ...");
            document.Validate(eventHandler);
        }

        private static void ValidationEventHandler(object sender, ValidationEventArgs e)
        {
            switch (e.Severity)
            {
                case XmlSeverityType.Error:
                    Console.WriteLine("Error: {0}", e.Message);
                    break;
                case XmlSeverityType.Warning:
                    Console.WriteLine("Warning: {0}", e.Message);
                    break;
                default:
                    break;
            }
        }
    }
}
