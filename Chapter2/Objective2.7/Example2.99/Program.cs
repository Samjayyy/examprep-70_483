using System;
using System.Globalization;

namespace Example2._99
{
    class Program
    {
        static void Main(string[] args)
        {
            Person1 p = new Person1("John", "Doe");
            Console.WriteLine("Person1: ");
            Console.WriteLine(string.Format("No format: {0}", p.ToString()));
            Console.WriteLine(string.Format("FL format: {0}", p.ToString("FL")));
            Console.WriteLine(string.Format("LF format: {0}", p.ToString("LF")));
            Console.WriteLine(string.Format("FSL format: {0}", p.ToString("FSL")));
            Console.WriteLine(string.Format("LSF format: {0}", p.ToString("LSF")));

            Console.WriteLine();
            Console.WriteLine("Person2: ");
            Person2 p2 = new Person2("John", "Doe");
            Console.WriteLine(string.Format("No format: {0}", p2.ToString()));
            Console.WriteLine(string.Format("FL format: {0}", p2.ToString("FL")));
            Console.WriteLine(string.Format("LF format: {0}", p2.ToString("LF")));
            Console.WriteLine(string.Format("FSL format: {0}", p2.ToString("FSL")));
            Console.WriteLine(string.Format("LSF format: {0}", p2.ToString("LSF")));

            Console.Write("Press a key to exit");
            Console.ReadKey();
        }
    }

    class Person1
    {
        public Person1(string firstName, string lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }

        public override string ToString()
        {
            return this.FirstName + " " + this.LastName;
        }

        public string ToString(string format)
        {
            if (string.IsNullOrWhiteSpace(format) || format == "G")
            {
                format = "FL";
            }

            format = format.Trim().ToUpperInvariant();

            switch (format)
            {
                case "FL":
                    return this.FirstName + " " + this.LastName;
                case "LF":
                    return this.LastName + " " + this.FirstName;
                case "FSL":
                    return this.FirstName + ", " + this.LastName;
                case "LSF":
                    return this.LastName + ", " + this.FirstName;
                default:
                    throw new FormatException(string.Format("The '{0}' format string is not supported.", format));
            }
        }
    }

    class Person2 : IFormattable
    {
        public Person2(string firstName, string lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }

        public override string ToString()
        {
            return this.ToString("G", CultureInfo.CurrentCulture);
        }

        public string ToString(string format)
        {
            return this.ToString(format, CultureInfo.CurrentCulture);
        }

        public string ToString(string format, IFormatProvider formatProvider)
        {
            if (string.IsNullOrWhiteSpace(format) || format == "G")
            {
                format = "FL";
            }

            format = format.Trim().ToUpperInvariant();

            switch (format)
            {
                case "FL":
                    return this.FirstName + " " + this.LastName;
                case "LF":
                    return this.LastName + " " + this.FirstName;
                case "FSL":
                    return this.FirstName + ", " + this.LastName;
                case "LSF":
                    return this.LastName + ", " + this.FirstName;
                default:
                    throw new FormatException(string.Format("The '{0}' format string is not supported.", format));
            }
        }
    }

}
