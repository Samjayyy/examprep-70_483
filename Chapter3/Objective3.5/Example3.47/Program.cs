using System;
using System.Diagnostics;
using System.IO;

namespace Example3._47
{
    class Program
    {
        static void Main(string[] args)
        {
            Stream outputFile = File.Create("tracefile.txt");
            TextWriterTraceListener textListener = new TextWriterTraceListener(outputFile);

            TraceSource traceSource = new TraceSource("myTraceSource", SourceLevels.All);

            traceSource.Listeners.Clear();
            traceSource.Listeners.Add(textListener);

            traceSource.TraceInformation("Trace output");

            traceSource.Flush();
            traceSource.Close();

            Console.WriteLine("tracefile.txt created in output directory.");
            Console.WriteLine("Press a key to exit");
            Console.ReadKey();
        }
    }
}
