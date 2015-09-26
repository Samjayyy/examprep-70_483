using System;
using System.IO;
using System.Text;

namespace Example4._15
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = "test.dat"; // Will create file test.dat in the outputdirectory of the project
            CleanUp(path);
            using (StreamWriter streamWriter = File.CreateText(path))
            {
                string myValue = "MyValue";
                Console.WriteLine("Writing {0}", myValue);
                streamWriter.Write(myValue);
            }

            Console.WriteLine("Data wrote.");

            using (FileStream fileStream = File.OpenRead(path))
            {
                byte[] data = new byte[fileStream.Length];

                for (int index = 0; index < fileStream.Length; index++)
                {
                    data[index] = (byte)fileStream.ReadByte();
                }

                Console.WriteLine("Reading with FileStream: {0}", Encoding.UTF8.GetString(data));
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
