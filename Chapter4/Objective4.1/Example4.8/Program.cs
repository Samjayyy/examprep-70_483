using System;
using System.IO;

namespace Example4._8
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = "test.text";

            if (File.Exists(path))
            {
                File.Delete(path);
                Console.WriteLine("{0} deleted", path);
            }
            else
            {
                using (File.Create(path)) { }
                Console.WriteLine("{0} created", path);
            }

            FileInfo fileInfo = new FileInfo(path);

            if (fileInfo.Exists)
            {
                fileInfo.Delete();
                Console.WriteLine("{0} deleted", path);
            }
            else
            {
                using (File.Create(path)) { }
                Console.WriteLine("{0} created", path);
            }

            Console.Write("Press a key to exit ... ");
            Console.ReadKey();
        }
    }
}
