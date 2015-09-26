using System;
using System.IO;

namespace Example2._84
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    class UnmanagedWrapper : IDisposable
    {
        public FileStream Stream { get; private set; }

        public UnmanagedWrapper()
        {
            this.Stream = File.Open("temp.dat", FileMode.Create);
        }

        ~UnmanagedWrapper()
        {
            this.Dispose(false);
        }

        public void Close()
        {
            this.Dispose();
        }

        private void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (this.Stream != null)
                {
                    this.Stream.Close();
                }
            }
        }

        public void Dispose()
        {
            Dispose(true);
            System.GC.SuppressFinalize(this);
        }
    }
}
