using System;
using System.Collections.Generic;
using System.Text;

namespace BrusAutomatSimonOgEirik
{
    class SodaFactory : Factory
    {
        private List<Product> SodaList;
        public SodaFactory()
        {
            SodaList = new List<Product> 
            {
                new Soda("glass", 330, 250, "Coca Cola", 2),
                new Soda("plastic", 500, 200, "Coca Cola", 1),
            };
        }

        private List<Soda> FactorySodaStorage = new List<Soda>();
        public override void MakeProduct(Product, int amount)
        {
            for (var i = 0; i < amount; i++)
            {
                FactorySodaStorage.Add(new Soda(type));
            }
        }
        public override void SendProductToStorage()
        {
            Storage.StorageContainer = FactorySodaStorage;
            FactorySodaStorage.Clear();
        }
    }
}
