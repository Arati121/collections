using System;
using System.Collections.Generic;
using System.Text;

namespace collection
{
    class Queue_Generic1
    {
        static void Main(string[] args)
        {
            Queue<String> q1 = new Queue<string>();
            q1.Enqueue("sunday");
            q1.Enqueue("monday");
            q1.Enqueue("tuseday");

            foreach(object item in q1)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("_____dequeue data___________");
            q1.Dequeue();
            foreach (object item in q1)
            {
                Console.WriteLine(item);
            }


        }
    }
}
