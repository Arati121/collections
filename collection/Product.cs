using System;
using System.Collections.Generic;
using System.Text;

namespace collection
{
    class Product
    {

        private int code;
        private String name;
        private double price;

        public Product(int code,string name,double price)
        {
            this.code = code;
            this.name = name;
            this.price = price;

        }

        public override string ToString()
        {
            return code + " " + name + "  " + price;
        }
    }
}
