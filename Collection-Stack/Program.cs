using System;
using System.Collections;
using System.Collections.Generic;

namespace Collection_Stack
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Stack<string> myStack = new Stack<string>();
            myStack.Push("first item");
            myStack.Push("second item");
            myStack.Push("third item");

            foreach (var item in myStack)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine(myStack.Pop());  // pop() removes the item from the stack
            Console.WriteLine(myStack.Peek()); // peek() will not remove item from stack
        }
    }
}
