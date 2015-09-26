using System;
using System.IO;

namespace Example4._9
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = "test.text";
            string destPath = "testNewName.text";

            if (File.Exists(destPath))
            {
                File.Delete(destPath);
                Console.WriteLine("{0} deleted", destPath);
            }

            File.Create(path).Close();
            Console.WriteLine("{0} created", path);
            File.Move(path, destPath);
            Console.WriteLine("Moved {0} to {1}", path, destPath);

            Console.WriteLine();

            path = "test2.text";
            destPath = "test2NewName.text";

            FileInfo fileInfo = new FileInfo(path);
            FileInfo destFileInfo = new FileInfo(destPath);

            if (destFileInfo.Exists)
            {
                destFileInfo.Delete();
                Console.WriteLine("{0} deleted", destFileInfo.Name);
            }

            File.Create(path).Close();
            Console.WriteLine("{0} created", fileInfo.Name);
            fileInfo.MoveTo(destPath);
            Console.WriteLine("Moved {0} to {1}", path, destPath);

            Console.Write("Press a key to exit ... ");
            Console.ReadKey();
        }
    }
}
