using System;
using System.Collections.Generic;
using System.Text;

namespace BrusAutomatSimonOgEirik
{
    abstract class VendingMachine : Transactions
    {
        public abstract Soda ChooseSoda(Product);
        public abstract void getProductFromStorage();
        internal abstract void SpitOutProduct();
    }
}
