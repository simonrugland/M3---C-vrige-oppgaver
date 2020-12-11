using System;
using System.Collections.Generic;
using System.Text;

namespace BrusAutomatSimonOgEirik
{
    class CandyFactory
    {
        private IEnumerable<Product> CandyList;

        public CandyFactory()
        {
            CandyList = new List<Product>
            {
                new Chocolate("Dark",50, "Mars", 2),
                new Chocolate("White", 9001, "Twix", 2),
                new Chocolate("Dark", 20, "Snickers", 2),
                new Chocolate("Dark", 20, "Monolith", 2),
                new Chocolate("White", 20, "White Lion", 2),
            };
        }

    }
}
