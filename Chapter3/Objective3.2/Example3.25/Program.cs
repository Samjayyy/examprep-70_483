using System;
using System.Security;
using System.Security.Permissions;

namespace Example3._25
{
    class Program
    {
        static void Main(string[] args)
        {
            
        }

        [FileIOPermissionAttribute(SecurityAction.Demand, AllLocalFiles = FileIOPermissionAccess.Read)]
        public static void DeclarativeCAS()
        {
            // Method body
        }

        private static void ImperativeCAS()
        {
            FileIOPermission f = new FileIOPermission(PermissionState.None);
            f.AllLocalFiles = FileIOPermissionAccess.Read;
            try
            {
                f.Demand();
            }
            catch (SecurityException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
