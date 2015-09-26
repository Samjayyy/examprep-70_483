using System;
using System.IO;
using System.Threading.Tasks;

namespace Example4._23
{
    class Program
    {
        static void Main(string[] args)
        {
            var task = CreateAndWriteAsyncToFile();
            while (!task.IsCompleted)
            {
                Console.Write("*");
            }

            Console.WriteLine();
            Console.Write("Press a key to exit ... ");
            Console.ReadKey();
        }

        public static async Task CreateAndWriteAsyncToFile()
        {
            var path = "test.dat";
            CleanUp(path);

            using (FileStream stream = new FileStream(path, FileMode.Create, FileAccess.Write, FileShare.None, 4096, true))
            {
                byte[] data = new byte[100000];
                new Random().NextBytes(data);
                Console.WriteLine("Writing data to test.dat ...");

                await stream.WriteAsync(data, 0, data.Length);
            }
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
