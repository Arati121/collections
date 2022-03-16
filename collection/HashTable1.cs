using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace collection
{
    class HashTable1
    {
        static void Main(string[] args)
        {
            Hashtable h1 = new Hashtable();
            h1.Add(101, "raj");
            h1.Add(102, "akash");
            h1.Add(111, "soonam");
            h1.Add(11, "Arati");

            foreach(DictionaryEntry data in h1)
            {
                Console.WriteLine(data.Key + " " + data.Value);
               
            }

            Console.WriteLine("after remove key=11");
            h1.Remove(11);
            foreach(DictionaryEntry item in h1)
            {
                Console.WriteLine(item.Key + " " + item.Value);
            }


        }
    }
}
