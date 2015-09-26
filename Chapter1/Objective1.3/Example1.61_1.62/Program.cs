using System;

namespace Example1._61
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Check with if:");
            Check('a');

            Console.WriteLine("Check with switch:");
            CheckWithSwitch('a');

            Console.Write("Press a key to exit");
            Console.ReadKey();
        }

        private static void Check(char input)
        {
            if (input == 'a'
            || input == 'e'
            || input == 'i'
            || input == 'o'
            || input == 'u')
            {
                Console.WriteLine("Input is a vowel");
            }
            else
            {
                Console.WriteLine("Input is a consonant");
            }
        }

        public static void CheckWithSwitch(char input)
        {
            switch (input)
            {
                case 'a':
                case 'e':
                case 'i':
                case 'o':
                case 'u':
                    {
                        Console.WriteLine("Input is a vowel");
                        break;
                    }
                case 'y':
                    {
                        Console.WriteLine("Input is sometimes a vowel.");
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Input is a consonant");
                        break;
                    }
            }
        }
    }
}
