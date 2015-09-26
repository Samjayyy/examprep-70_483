using System;

namespace Example2._85
{
    class Program
    {
        static WeakReference data;

        static void Main(string[] args)
        {
        }

        public static void Run()
        {
            object result = GetData();
            // GC.Collect(); // Uncommneting this line will make data.Target null
            result = GetData();
        }

        private static object GetData()
        {
            if (data == null)
            {
                data = new WeakReference(LoadLargeList());
            }

            if (data.Target ==null)
            {
                data.Target = LoadLargeList();
            }

            return data.Target;
        }

        private static object LoadLargeList()
        {
            // Some implementation here

            return null;
        }
    }
}
