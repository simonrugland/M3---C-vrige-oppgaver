
using System;
using System.Collections.Generic;
using System.Text;

namespace BrusAutomatSimonOgEirik
{
    class Chocolate : Product
    {
        private readonly string Color;
        public Chocolate(string color, double price, string name, int storage) : base(price, name, storage)
        {
            Color = color;
        }
    }
}
