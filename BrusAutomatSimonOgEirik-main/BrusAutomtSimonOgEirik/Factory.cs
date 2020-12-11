using System;
using System.Collections.Generic;
using System.Text;

namespace BrusAutomatSimonOgEirik
{
    abstract class Factory
    {
        public abstract void MakeProduct(Product.Types type, int amount);
        public abstract void SendProductToStorage();
    }
}
