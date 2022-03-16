using System;
using System.Collections.Generic;
using System.Text;

namespace collection
{
    class Genric_Swap
    {
       
            static void swap<T>(ref T a,ref T b)
            {
                T temp;
                temp = a;
                a = b;
                b = temp;
            }
        static void Main(string[] args)
        {
            int a = 10, b = 20;
            swap<int>(ref a, ref b);
            Console.WriteLine(a+" "+b);

        }
    }
}
