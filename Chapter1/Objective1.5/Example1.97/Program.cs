using System;
using System.Runtime.ExceptionServices;

namespace Example1._97
{
    class Program
    {
        static void Main(string[] args)
        {
            ExceptionDispatchInfo possibleException = null;
            try
            {
                Console.Write("Enter an string to cause an exception: ");
                string s = Console.ReadLine();
                int.Parse(s);
            }
            catch (FormatException ex)
            {
                possibleException = ExceptionDispatchInfo.Capture(ex);
            }

            if (possibleException != null)
            {
                possibleException.Throw();
            }
        }
    }
}
