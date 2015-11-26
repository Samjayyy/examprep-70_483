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
            Console.WriteLine("\nmyQueue length: {0}", myQueue.Count);

            Console.WriteLine("\nUsing Dequeue");
            while (myQueue.Count > 0)
            {
                Console.Write(myQueue.Dequeue() + " ");
            }
            Console.WriteLine("\nmyQueue length: {0}", myQueue.Count);

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
            Console.WriteLine("\nmyStack length: {0}", myStack.Count);

            Console.WriteLine("\nUsing Pop");
            while (myStack.Count > 0)
            {
                Console.Write(myStack.Pop() + " ");
            }
            Console.WriteLine("\nmyStack length: {0}", myStack.Count);

            Console.WriteLine();
            Console.Write("Press a key to exit ... ");
            Console.ReadKey();
        }
    }
}
