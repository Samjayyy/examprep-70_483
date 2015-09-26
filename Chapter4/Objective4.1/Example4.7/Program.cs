using System;
using System.IO;

namespace Example4._7
{
    class Program
    {
        static void Main(string[] args)
        {
            var path = @"C:\Windows";
            foreach (string file in Directory.GetFiles(path))
            {
                Console.WriteLine(file);
            }

            DirectoryInfo directoryInfo = new DirectoryInfo(path);
            foreach (FileInfo fileInfo in directoryInfo.GetFiles())
	        {
		        Console.WriteLine(fileInfo.FullName);
	        }

            Console.Write("Press a key to exit ... ");
            Console.ReadKey();
        }
    }
}
