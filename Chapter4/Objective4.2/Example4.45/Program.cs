using System;
using System.Xml;

namespace Example4._45
{
    class Program
    {
        static void Main(string[] args)
        {
            XmlDocument doc = new XmlDocument();
            string xml = @"<?xml version=""1.0"" encoding=""utf-8"" ?>
                        <people>
                            <person firstname=""john"" lastname=""doe"">
                                <contactdetails>
                                    <emailaddress>john@unknown.com</emailaddress>
                                </contactdetails>
                            </person>
                            <person firstname=""jane"" lastname=""doe"">
                                <contactdetails>
                                    <emailaddress>jane@unknown.com</emailaddress>
                                    <phonenumber>001122334455</phonenumber>
                                </contactdetails>
                            </person>
                        </people>";
            doc.LoadXml(xml);
            XmlNodeList nodes = doc.GetElementsByTagName("Person");

            // Output the names of the people in the document
            foreach (XmlNode node in nodes)
            {
                string firstName = node.Attributes["firstname"].Value;
                string lastName = node.Attributes["lastname"].Value;
                Console.WriteLine("Names: {0} {1}", firstName, lastName);
            }

            // Start creating a new node
            XmlNode newNode = doc.CreateNode(XmlNodeType.Element, "Person", "");

            XmlAttribute firstNameAttribute = doc.CreateAttribute("firstname");
            firstNameAttribute.Value = "Foo";

            XmlAttribute lastNameAttribute = doc.CreateAttribute("lastNname");
            lastNameAttribute.Value = "Bar";

            newNode.Attributes.Append(firstNameAttribute);
            newNode.Attributes.Append(lastNameAttribute);

            doc.DocumentElement.AppendChild(newNode);
            Console.WriteLine("Modified xml...");
            doc.Save(Console.Out);

            Console.WriteLine();
            Console.Write("Press a key to exit ... ");
            Console.ReadKey();
        }
    }
}
