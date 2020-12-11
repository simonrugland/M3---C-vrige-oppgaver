using System;
using System.Collections.Generic;
using System.Text;

namespace BrusAutomatSimonOgEirik
{
    class Product
    {
       
        public readonly double Price;
        public readonly string Name;
        public int Storage;
         
        public Product(double price, string name, int storage)
        {
            Price = price;
            Name = name;
            Storage = storage;
        }
    }
}
