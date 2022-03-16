using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace collection
{
    class Stack1
    {
        static void Main(string[] args)
        {
            Stack stack = new Stack();
            stack.Push(11);
            stack.Push("rohit");
            stack.Push(60.5);
            stack.Push(100);
            Console.WriteLine("________push the data____________");
            Console.WriteLine("foreach loop");
            foreach(object print in stack)
            {
                Console.WriteLine(print);
            }

            

            Console.WriteLine("________________pop the element____________");
            stack.Pop();
            foreach (object print in stack)
            {
                Console.WriteLine(print);
            }
            Console.WriteLine("second pop element");
            stack.Pop();
            foreach (object print in stack)
            {
                Console.WriteLine(print);
            }

        }
    }
}
