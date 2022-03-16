using System;
using System.Collections.Generic;
using System.Text;

namespace collection
{
    class Stack_Generic
    {
        static void Main(string[] args)
        {
            Stack<int> s1 = new Stack<int>();
            s1.Push(101);
            s1.Push(102);
            s1.Push(52);

            foreach(object item in s1)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("poping the data");
            s1.Pop();

            foreach (object item in s1)
            {
                Console.WriteLine(item);
            }





        }
    }
}
