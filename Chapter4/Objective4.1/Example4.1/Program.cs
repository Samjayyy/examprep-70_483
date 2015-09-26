using System;
using System.IO;

namespace Example4._1
{
    class Program
    {
        private static DriveInfo[] drivesInfo = DriveInfo.GetDrives();

        static void Main(string[] args)
        {
            foreach (var driveInfo in drivesInfo)
            {
                Console.WriteLine("Drive {0}", driveInfo.Name);
                Console.WriteLine("  File type: {0}", driveInfo.DriveType);

                if (driveInfo.IsReady)
                {
                    Console.WriteLine("  Volume label: {0}", driveInfo.VolumeLabel);
                    Console.WriteLine("  File system: {0}", driveInfo.DriveFormat);
                    Console.WriteLine("  Available space to current user: {0} bytes", driveInfo.AvailableFreeSpace);
                    Console.WriteLine("  Total avaiable space: {0, 15} bytes", driveInfo.TotalFreeSpace);
                    Console.WriteLine("  Total size of drive: {0, 15} bytes", driveInfo.TotalFreeSpace);
                }
            }

            Console.WriteLine("Press a key to exit");
            Console.ReadKey();
        }
    }
}
