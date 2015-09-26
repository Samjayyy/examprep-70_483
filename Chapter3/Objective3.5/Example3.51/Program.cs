using System;
using System.Diagnostics;

namespace Example3._51
{
    class Program
    {
        static void Main(string[] args)
        {
            EventLog applicationLog = new EventLog("Application", ".", "testEventLogEvent");
            applicationLog.EntryWritten += (sender, e) =>
            {
                Console.WriteLine(e.Entry.Message);
            };
            applicationLog.EnableRaisingEvents = true;
            applicationLog.WriteEntry("Test message",EventLogEntryType.Information);
            Console.ReadKey();
        }
    }
}
