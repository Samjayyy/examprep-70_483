using System;
using System.IO;

namespace Example4._2
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstDirectoryPath = @"C:\ProgrammingInCSharpDirectory";
            var secondDirectoryPath = @"C:\ProgrammingInCSharpDirectoryInfo";
            var diretory = Directory.CreateDirectory(firstDirectoryPath);
            Console.WriteLine("Created diretory: {0}", firstDirectoryPath);

            var diretoryInfo = new DirectoryInfo(secondDirectoryPath);
            diretoryInfo.Create();
            Console.WriteLine("Created diretory: {0}", secondDirectoryPath);
            Console.Write("Press 'Enter' to delete the created folders: ");
            ConsoleKeyInfo cki = Console.ReadKey(true);
            if (cki.Key == ConsoleKey.Enter)
            {
                if (Directory.Exists(firstDirectoryPath))
                {
                    Directory.Delete(firstDirectoryPath);
                    Console.WriteLine();
                    Console.WriteLine("Deleted: {0}", firstDirectoryPath);
                }

                if (diretoryInfo.Exists)
                {
                    diretoryInfo.Delete();
                    Console.WriteLine("Deleted: {0}", secondDirectoryPath);
                }
            }
            else
            {
                Console.WriteLine("Created folders were not deleted");
            }

            Console.Write("Press a key to exit ... ");
            Console.ReadKey();
        }
    }
}
