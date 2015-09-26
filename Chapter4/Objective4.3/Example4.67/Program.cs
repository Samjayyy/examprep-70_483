using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Linq;

namespace Example4._67
{
    class Program
    {
        static void Main(string[] args)
        {
            var path = "test.xml";
            if (File.Exists(path))
            {
                File.Delete(path);
                Console.WriteLine("{0} deleted", path);
            }

            XElement root = new XElement("Root", new List<XElement>
            {
                new XElement("Child1"),
                new XElement("Child2"),
                new XElement("Child3")
            },
            new XAttribute("MyAttribute", 42));
            root.Save(path);
            Console.WriteLine("{0} created:", path);
            Console.WriteLine(root.ToString());

            Console.Write("Press a key to exit ... ");
            Console.ReadKey();
        }
    }
}
