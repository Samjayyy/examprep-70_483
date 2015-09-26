using System;
using System.Diagnostics;

namespace Example3._50
{
    class Program
    {
        static void Main(string[] args)
        {
            // Before running this example make sure that the Example3.49 has been executed correctly.

            EventLog log = new EventLog("MyNewLog");
            Console.WriteLine("Total entries: " + log.Entries.Count);
            EventLogEntry last = log.Entries[log.Entries.Count - 1];
            Console.WriteLine("Index: " + last.Index);
            Console.WriteLine("Source: " + last.Source);
            Console.WriteLine("EntryType: " + last.EntryType);
            Console.WriteLine("TimeWritten: " + last.TimeWritten);
            Console.WriteLine("Message: " + last.Message);

            Console.WriteLine("Press a key to exit");
            Console.ReadKey();
        }
    }
}
