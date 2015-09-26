using System;
using System.Collections.Generic;
using System.Web.Script.Serialization;

namespace Example3._12
{
    class Program
    {
        static void Main(string[] args)
        {
            var json = "{\"employees\":[{\"firstName\":\"John\", \"lastName\":\"Doe\"}, {\"firstName\":\"Anna\", \"lastName\":\"Smith\"},{\"firstName\":\"Peter\", \"lastName\":\"Jones\"}]}";
            Console.WriteLine("Testing with IsJson() if {0}", json);
            Console.WriteLine("");
            Console.WriteLine("Result: {0}", IsJson(json));

            var serializer = new JavaScriptSerializer();
            var result = serializer.Deserialize <Dictionary<string, object>>(json);
            Console.WriteLine("JavaScriptSerializer.Deserialize was successful");
            Console.WriteLine("Press a key to exit");
            Console.ReadKey();
        }

        public static bool IsJson(string input)
        {
            input = input.Trim();

            return (input.StartsWith("{") && input.EndsWith("}")) || (input.StartsWith("[") && input.EndsWith("]"));
        }
    }
}
