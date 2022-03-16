using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace collection
{
    class Deque1
    {
        static void Main(string[] args)
        {
            Queue deue = new Queue();
            deue.Enqueue(101);
            deue.Enqueue("rohit");
            deue.Enqueue(101);
            deue.Enqueue(10.7);

            Console.WriteLine("enqueue data add data");//enqueue data
            foreach(object data in deue)
            {
                Console.WriteLine(data);
            }

            deue.Dequeue();   // dequeu data
            Console.WriteLine("  dequeu data  FIFO   ");
            foreach (object data in deue)
            {
                Console.WriteLine(data);
            }


        }
    }
}
