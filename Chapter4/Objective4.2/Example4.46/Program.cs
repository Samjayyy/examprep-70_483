using System;
using System.Xml;
using System.Xml.XPath;

namespace Example4._46
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
            XPathNavigator nav = doc.CreateNavigator();
            string query = "//people/person[@firstname='jane']";
            XPathNodeIterator iterator = nav.Select(query);
            Console.WriteLine(iterator.Count);
            while (iterator.MoveNext())
            {
                string firstName = iterator.Current.GetAttribute("firstname", "");
                string lastName = iterator.Current.GetAttribute("lastname", "");
                Console.WriteLine("Name: {0} {1}", firstName, lastName);
            }

            Console.Write("Press a key to exit ... ");
            Console.ReadKey();
        }
    }
}
