using System;
using System.IO;

namespace Example1._12
{
    class Program
    {
        static void Main(string[] args)
        {
            string folder = @"C:\temp\subdir\";
            string fileName = "file.txt";

            string fullPath = Path.Combine(folder, fileName);

            Console.WriteLine("Final path: {0}", fullPath);
            Console.WriteLine("DirectoryName {0}", Path.GetDirectoryName(fullPath));
            Console.WriteLine("Extension {0}", Path.GetExtension(fullPath));
            Console.WriteLine("FileName {0}", Path.GetFileName(fullPath));
            Console.WriteLine("PathRoot {0}", Path.GetPathRoot(fullPath));

            Console.Write("Press a key to exit ... ");
            Console.ReadKey();
        }
    }
}
