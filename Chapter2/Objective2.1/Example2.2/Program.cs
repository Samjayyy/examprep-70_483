
using System;

namespace Example2._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Point p = new Point(1, 1);

            Console.WriteLine(p);
            Console.ReadKey();
        }
    }

    public struct Point
    {
        private int x, y;

        public Point(int p1, int p2)
        {
            x = p1;
            y = p2;
        }

        public override string ToString()
        {
            return x+" "+y;
        }
    }
}
