using System;
using System.IO;
using System.Security.AccessControl;

namespace Example4._4
{
    class Program
    {
        static void Main(string[] args)
        {
            DirectoryInfo directoryInfo = new DirectoryInfo("TestDirectory");
            directoryInfo.Create();
            DirectorySecurity directorySecurity = directoryInfo.GetAccessControl();
            directorySecurity.AddAccessRule(new FileSystemAccessRule("everyone", FileSystemRights.ReadAndExecute, AccessControlType.Allow));
            directoryInfo.SetAccessControl(directorySecurity);
            Console.WriteLine("Opening newly created 'TestDirectory' folder: ");
            System.Diagnostics.Process.Start("explorer", directoryInfo.Name);

            Console.Write("Press a key to exit ... ");
            Console.ReadKey();
        }
    }
}
