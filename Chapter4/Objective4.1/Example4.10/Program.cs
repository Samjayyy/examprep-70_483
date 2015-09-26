using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example4._10
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = "test.txt";
            string destPath = "testNewName.txt";

            CleanUp(path, destPath);

            File.CreateText(path).Close();
            File.Copy(path, destPath);
            Console.WriteLine("{0} copied to {1}", path, destPath);

            Console.WriteLine();

            path = "test2.txt";
            destPath = "test2NewName.txt";

            CleanUp(path, destPath);

            File.CreateText(path).Close();
            FileInfo fileInfo = new FileInfo(path);
            fileInfo.CopyTo(destPath);

            Console.Write("Press a key to exit ... ");
            Console.ReadKey();
        }

        private static void CleanUp(string path, string destPath)
        {
            if (File.Exists(path))
            {
                File.Delete(path);
                Console.WriteLine("{0} deleted", path);
            }

            if (File.Exists(destPath))
            {
                File.Delete(destPath);
                Console.WriteLine("{0} deleted", destPath);
            }
        }
    }
}
