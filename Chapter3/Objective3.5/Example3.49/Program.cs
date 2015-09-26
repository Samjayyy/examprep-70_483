using System;
using System.Diagnostics;

namespace Example3._49
{
    class Program
    {
        static void Main(string[] args)
        {
            if (!EventLog.SourceExists("MySource"))
            {
                EventLog.CreateEventSource("MySource", "MyNewLog");
                Console.WriteLine("CreatedEventSource");
                Console.WriteLine("Please restart application");
                Console.ReadKey();
            }

            EventLog myLog = new EventLog();
            myLog.Source = "MySource";
            myLog.WriteEntry("Log event!");
        }
    }
}
