using System;
using System.Runtime.InteropServices;
using System.Security;

namespace Example3._27
{
    class Program
    {
        static void Main(string[] args)
        {
            using (SecureString ss = new SecureString())
            {
                Console.WriteLine("Please enter password:");
                while (true)
                {
                    ConsoleKeyInfo cki = Console.ReadKey(true);
                    if (cki.Key == ConsoleKey.Enter)
                    {
                        break;
                    }

                    ss.AppendChar(cki.KeyChar);
                    Console.Write("*");
                }

                ss.MakeReadOnly();
                Console.WriteLine();
                ConvertToUnsecureString(ss);
            }

            Console.WriteLine("Press a key to exit");
            Console.ReadKey();
        }

        private static void ConvertToUnsecureString(SecureString securePassword)
        {
            IntPtr unmanagedString = IntPtr.Zero;
            try
            {
                unmanagedString = Marshal.SecureStringToGlobalAllocUnicode(securePassword);
                Console.WriteLine("Password entered: {0}", Marshal.PtrToStringUni(unmanagedString));
            }
            finally
            {
                Marshal.ZeroFreeGlobalAllocUnicode(unmanagedString);
            }
        }
    }
}
