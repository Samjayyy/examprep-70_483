using System;
using System.IO;

namespace Example4._6
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstDirectoryPath = "source";
            var secondDirectoryPath = "destination";
            Directory.CreateDirectory(firstDirectoryPath);

            Directory.Move(firstDirectoryPath, secondDirectoryPath);

            // Or

            //DirectoryInfo directoryInfo = new DirectoryInfo(firstDirectoryPath);
            //directoryInfo.MoveTo(secondDirectoryPath);

            System.Diagnostics.Process.Start("explorer", secondDirectoryPath);
            Console.Write("Press 'Enter' to delete the created folders: ");
            ConsoleKeyInfo cki = Console.ReadKey(true);
            while (true)
            {
                if (cki.Key == ConsoleKey.Enter)
                {
                    if (Directory.Exists(secondDirectoryPath))
                    {
                        Directory.Delete(secondDirectoryPath);
                        Console.WriteLine();
                        Console.WriteLine("Deleted: {0}", secondDirectoryPath);

                        break;
                    }
                }
            }

            Console.Write("Press a key to exit ... ");
            Console.ReadKey();
        }
    }
}
