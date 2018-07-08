using System;
using System.Collections.Generic;

namespace Collection_Queue
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Queue<string> myQueue = new Queue<string>();
            myQueue.Enqueue("first item");
            myQueue.Enqueue("second item");
            myQueue.Enqueue("third item");

            foreach (var item in myQueue)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine(myQueue.Dequeue());  // Dequeue() removes the item from the stack
            Console.WriteLine(myQueue.Peek()); // peek() will not remove item from stack
        }
    }
}
