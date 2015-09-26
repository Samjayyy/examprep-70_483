using System;
using System.Threading.Tasks;

namespace Example1._9
{
    public class Program
    {
        public static void Main()
        {
            Task<int> t = Task.Run(() =>
                {
                    return 42;
                }).ContinueWith((i) =>
                {
                    return i.Result * 2;
                });
            Console.WriteLine(t.Result);
            Console.Write("Press a key to exit");
            Console.ReadKey();
        }
    }
}
