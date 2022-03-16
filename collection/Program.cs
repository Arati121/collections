using System;
using System.Collections;
using System.Collections.Generic;

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

            foreach (object data in list)
            {
                Console.WriteLine(data);
            }

            Console.WriteLine("____________for loop______________");
            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i]);
            }

            Console.WriteLine("memoery capacity= " + list.Capacity);

            Console.WriteLine("total count element= " + list.Count);

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

            List<Product> productlist = new List<Product>();
            Product p1 = new Product(101, "rajesh", 450000);
            Product p2 = new Product(101, "raj", 50000);
            Product p3 = new Product(101, "rajesh", 450000);

            productlist.Add(p1);
            productlist.Add(p2);
            productlist.Add(p3);
            List<Product> l1 = new List<Product>() { new Product(101, "rajesh", 450000), new Product(101, "raj", 50000), new Product(101, "rajesh", 450000)
            };

        }
    }
}
