using System.IO;

namespace Example4._20
{
    class Program
    {
        static void Main(string[] args)
        {
            var result = ReadAllText();
        }

        private static object ReadAllText()
        {
            string path = "test.txt";

            try
            {
                return File.ReadAllText(path);
            }
            catch (DirectoryNotFoundException)
            {
                // Some logic
            }
            catch (FileNotFoundException)
            { 
                // Some logic
            }

            return string.Empty;
        }
    }
}
