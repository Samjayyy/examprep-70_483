using System;
using System.IO;

namespace Example2._83
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamWriter stream = File.CreateText("temp.dat");
            stream.Write("Some data");
            Console.WriteLine("temp.dat created");
            stream.Dispose();
            Console.WriteLine("temp.dat dispose");
            File.Delete("temp.dat"); // Throws an IOException because the file is already open.

            Console.Write("Press a key to exit");
            Console.ReadKey();
        }
    }
}
