using System;
using System.Security;
using System.Security.Permissions;

namespace Example3._25
{
    class Program
    {
        static void Main(string[] args)
        {
            DeclarativeCAS();
            Console.ReadKey();
            Console.WriteLine("---------------");
            ImperativeCAS();
            Console.ReadKey();
        }

        public static void ReadFile()
        {
            string text = System.IO.File.ReadAllText(@"TextFile.txt");
            Console.WriteLine(text);
            var objW = System.IO.File.OpenText(@"TextFile.txt");
        }

        [FileIOPermission(SecurityAction.Demand, AllLocalFiles = FileIOPermissionAccess.Read)]
        public static void DeclarativeCAS()
        {
            // Method body
            ReadFile();
        }

        private static void ImperativeCAS()
        {
            FileIOPermission f = new FileIOPermission(PermissionState.None);
            f.AllLocalFiles = FileIOPermissionAccess.Read;
            try
            {
                f.Demand();
                ReadFile();
            }
            catch (SecurityException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
