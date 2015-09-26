using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;

namespace Example4._65
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
            XDocument doc = XDocument.Parse(xml);
            IEnumerable<string> personNames = from p in doc.Descendants("person")
                                              select (string)p.Attribute("firstname") + " " + (string)p.Attribute("lastname");
            Console.WriteLine("Displaying all persons: ");
            foreach (string s in personNames)
            {
                Console.WriteLine(s);
            }
            Console.WriteLine("");

            IEnumerable<string> personsWithNumberInAlphabeticOrder = from p in doc.Descendants("person")
                                                                     where p.Descendants("phonenumber").Any()
                                                                     let name = (string)p.Attribute("firstname") + " " + (string)p.Attribute("lastname")
                                                                     orderby name
                                                                     select name;
            Console.WriteLine("Displaying all persons with numbers in alphabetic order: ");
            foreach (string s in personsWithNumberInAlphabeticOrder)
            {
                Console.WriteLine(s);
            }

            Console.Write("Press a key to exit ... ");
            Console.ReadKey();
        }
    }
}
