using System;
using System.IO;
using System.Text;

namespace Example4._14
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = "test.dat"; // Will create file test.dat in the outputdirectory of the project
            CleanUp(path);
            using (FileStream fileStream = File.Create(path))
            {
                string myValue = "MyValue";
                byte[] data = Encoding.UTF8.GetBytes(myValue);
                Console.WriteLine("Writing {0}", data.ToSentenceCase());
                fileStream.Write(data, 0, data.Length);
            }

            Console.WriteLine("Data wrote.");
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

    public static class Extensions
    {
        public static string ToSentenceCase(this byte[] bytes)
        {
            StringBuilder sb = new StringBuilder();
            foreach (var value in bytes)
            {
                sb.Append(string.Format("{0}", value.ToString()));
            }

            return sb.ToString();
        }
    }
}
