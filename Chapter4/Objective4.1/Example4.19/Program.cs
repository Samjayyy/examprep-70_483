using System;
using System.IO;

namespace Example4._19
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = "bufferedStream.txt"; // Will create file bufferedStream.txt in the outputdirectory of the project
            CleanUp(path);
            using (FileStream fileStream = File.Create(path))
            {
                using (BufferedStream bufferedStream = new BufferedStream(fileStream))
                {
                    using (StreamWriter streamWriter = new StreamWriter(bufferedStream))
                    {
                        streamWriter.Write("A line of text");
                        Console.WriteLine("Data wrote.");
                    }
                }
            }

            Console.Write("Press a key to exit ... ");
            Console.ReadKey();
        }

        private static void CleanUp(string path)
        {
            if (File.Exists(path))
            {
                File.Delete(path);
                Console.WriteLine("{0} deleted", path);
            }
        }
    }
}
