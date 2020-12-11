using System;
using System.Collections.Generic;
using System.Text;

namespace BrusAutomatSimonOgEirik
{
    class SodaMachine : VendingMachine
    {
        private List<Soda> MachineStorage = new List<Soda>();
        public override Soda ChooseSoda(Product)
        {
            return null;
        }
        public override void getProductFromStorage()
        {
            throw new NotImplementedException();
        }

        internal override void SpitOutProduct()
        {
            throw new NotImplementedException();
        }
    }
}
