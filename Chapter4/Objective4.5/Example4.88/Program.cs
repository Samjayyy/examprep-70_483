using System;
using System.Collections.Generic;

namespace Example4._88
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<string> myQueue = new Queue<string>();
            myQueue.Enqueue("Hello");
            myQueue.Enqueue("World");
            myQueue.Enqueue("From");
            myQueue.Enqueue("A");
            myQueue.Enqueue("Queue");

            Console.WriteLine("Using Queue");
            foreach (string s in myQueue)
            {
                Console.Write(s + " ");
            }

            Console.WriteLine();

            Stack<string> myStack = new Stack<string>();
            myStack.Push("Hello");
            myStack.Push("World");
            myStack.Push("From");
            myStack.Push("A");
            myStack.Push("Queue");

            Console.WriteLine("Using Stack");
            foreach (string s in myStack)
            {
                Console.Write(s + " ");
            }

            Console.WriteLine();
            Console.Write("Press a key to exit ... ");
            Console.ReadKey();
        }
    }
}
