
using System;

namespace Example2._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Days readingDays = Days.Monday | Days.Saturday;

            Console.WriteLine(Days.Monday+" | "+Days.Saturday);
            Console.WriteLine("days: "+readingDays.ToString());
            Console.ReadKey();
        }
    }

    //[Flags]
    public enum Days
    { 
        None = 0x0,
        Sunday = 0x1,
        Monday = 0x2,
        Tuesday = 0x4,
        Wednesday = 0x8,
        Thursday = 0x10,
        Friday = 0x20,
        Saturday = 0x40
    }
}
