using System;
using System.IO;

namespace Example2._23
{
    class Program
    {
        static void Main(string[] args)
        {
            object stream = new MemoryStream();
            MemoryStream memoryStream = (MemoryStream)stream;

            Console.WriteLine($"stream = {stream}");
            Console.WriteLine($"memoryStream = {memoryStream}");

            Console.Write("Press a key to exit");
            Console.ReadKey();
        }
    }
}
