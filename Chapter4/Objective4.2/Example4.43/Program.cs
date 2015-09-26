using System;
using System.IO;
using System.Xml;

namespace Example4._43
{
    class Program
    {
        static void Main(string[] args)
        {
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

            using (StringReader stringreader = new StringReader(xml))
            {
                using (XmlReader xmlReader = XmlReader.Create(stringreader, new XmlReaderSettings() { IgnoreWhitespace = true }))
                {
                    xmlReader.MoveToContent();
                    xmlReader.ReadStartElement("people");

                    string firstName = xmlReader.GetAttribute("firstname");
                    string lastName = xmlReader.GetAttribute("lastname");

                    Console.WriteLine("Person: {0} {1}", firstName, lastName);
                    xmlReader.ReadStartElement("person");

                    Console.WriteLine("ContactDetails");

                    xmlReader.ReadStartElement("contactdetails");
                    string emailAddress = xmlReader.ReadString();

                    Console.WriteLine("Email address: {0}", emailAddress);
                }
            }

            Console.Write("Press a key to exit ... ");
            Console.ReadKey();
        }
    }
}
