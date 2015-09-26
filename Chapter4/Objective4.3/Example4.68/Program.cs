using System;
using System.Linq;
using System.Xml.Linq;

namespace Example4._68
{
    class Program
    {
        static void Main(string[] args)
        {
            String xml = @"<?xml version=""1.0"" encoding=""utf-8"" ?>
                            <people>
                                <person firstname=""John"" lastname=""Doe"">
                                    <contactdetails>
                                        <emailaddress>john@unknown.com</emailaddress>
                                    </contactdetails>
                                </person>
                                <person firstname=""Jane"" lastname=""Doe"">
                                    <contactdetails>
                                        <emailaddress>jane@unknown.com</emailaddress>
                                        <phonenumber>001122334455</phonenumber>
                                    </contactdetails>
                                </person>
                                <person firstname=""Albert"" lastname=""Einstein"">
                                    <contactdetails>
                                        <emailaddress>albert@unknown.com</emailaddress>
                                        <phonenumber>001111111111</phonenumber>
                                    </contactdetails>
                                </person>
                            </people>";
            XElement root = XElement.Parse(xml);

            // Using XML in a procedural way
            Console.WriteLine("Using XML in a procedural way");
            foreach (XElement p in root.Descendants("Person"))
            {
                string name = (string)p.Attribute("firstname") + (string)p.Attribute("lastname ");
                p.Add(new XAttribute("IsMale", name.Contains("John")));
                XElement contactsDetails = p.Element("contactdetails");
                if (!contactsDetails.Descendants("phonenumber").Any())
                {
                    contactsDetails.Add(new XElement("phonenumber", "001122334455"));
                }
            }

            Console.WriteLine(root.ToString());
            Console.WriteLine();

            // Transforming XML with functional creation
            Console.WriteLine("Transforming XML with functional creation");
            XElement newTree = new XElement("people",
                from p in root.Descendants("person")
                let name = (string)p.Attribute("firstname") + (string)p.Attribute("lastname")
                let ContactDetails = p.Element("contactdetails")
                select new XElement("person", new XAttribute("IsMale", name.Contains("John")),
                    p.Attributes(),
                    new XElement("contactdetails", ContactDetails.Element("emailaddress"), ContactDetails.Element("phonenumber") ?? new XElement("phonenumber", "112233455"))));

            Console.WriteLine(newTree.ToString());

            Console.Write("Press a key to exit ... ");
            Console.ReadKey();
        }
    }
}
