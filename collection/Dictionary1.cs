using System;
using System.Collections.Generic;
using System.Text;

namespace collection
{
    class Dictionary1
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> d1 = new Dictionary<int, string>();
            d1.Add(111, "pavan");
            d1.Add(1, "arati");
            d1.Add(110, "ram");
            d1.Add(5, "nikita");
            foreach(KeyValuePair<int,string> item in d1)
            {
                Console.WriteLine(item);
            }

       

        }
    }
}
