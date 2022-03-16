using System;
using System.Collections;

namespace collection
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList list = new ArrayList();
            list.Add(10);
            list.Add(3.2);
            list.Add("arati");
            list.Add(100);

            list.Insert(1, "pooja");

            Console.WriteLine("___________For each______________");

            foreach(object data in list)
            {
                Console.WriteLine(data);
            }

            Console.WriteLine("____________for loop______________");
            for(int i=0;i<list.Count; i++)
            {
                Console.WriteLine(list[i]);
            }

            Console.WriteLine("memoery capacity= "+list.Capacity);

            Console.WriteLine("total count element= "+list.Count);

            Console.WriteLine("_____remove method_________");
            list.Remove("arati");
            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i]);
            }

            Console.WriteLine("__________removeAt() method___________");
            list.RemoveAt(1);
            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i]);
            }

        }
    }
}
