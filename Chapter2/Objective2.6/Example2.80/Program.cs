using System;
using System.IO;

namespace Example2._80
{
    // NOTE:
    // In debug mode, the compiler will make sure that the reference isn’t garbage collected till the end of the method.
    // Execute the project in release mode and press Ctrl + F5.

    class Program
    {
        static void Main(string[] args)
        {
            StreamWriter stream = File.CreateText("temp.dat");
            stream.Write("Some data");
            GC.Collect();
            GC.WaitForPendingFinalizers();
            File.Delete("temp.dat"); // Throws an IOException because the file is already open.
        }
    }
}
