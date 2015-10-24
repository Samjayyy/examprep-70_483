using System;
using System.Text.RegularExpressions;

namespace Example3._9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Validate a zipcode with a method");
            Validate("1234AB", WithMethod);
            Validate("0", WithMethod);
            Validate("1234 AB", WithMethod);
            Validate("123AB1", WithMethod);
            Validate(" 123AB", WithMethod);
            Validate("1234 AB", WithMethod);
            Console.WriteLine("-----------------");
            Console.WriteLine("Validate a zipcode with a regex");
            Validate("1234AB", WithRegex);
            Validate("0", WithRegex);
            Validate("1234 AB", WithRegex);
            Validate("123AB1", WithRegex);
            Validate(" 123AB", WithRegex);
            Validate("1234 AB", WithRegex);

            Console.ReadKey();

            BestPractices.ExampleBacktracking();
            Console.ReadKey();

            BestPractices.CompileVsInterpreted();
            Console.ReadKey();
        }

        static void Validate(string zipCode, Func<string,bool> check)
        {
            Console.WriteLine($"{zipCode} => {(check(zipCode) ? "valid" : "invalid")}");
        }

        static bool WithMethod(string zipCode)
        { 
            // Valid zopcodes: 1234AB | 1234 AB | 1001 AB

            if (zipCode.Length < 6) return false;

            string numberPart = zipCode.Substring(0, 4);
            int number;
            if (!int.TryParse(numberPart, out number)) return false;

            string characterPart = zipCode.Substring(4);

            if (numberPart.StartsWith("0")) return false;
            if (characterPart.Trim().Length < 2) return false;
            if (characterPart.Length == 3 && characterPart.Trim().Length != 2) return false;

            return true;
        }

        static bool WithRegex(string zipCode)
        {
            Match match = Regex.Match(zipCode, @"^[1-9][0-9]{3}\s?[a-zA-Z]{2}$", RegexOptions.IgnoreCase);

            return match.Success;
        }
    }
}
