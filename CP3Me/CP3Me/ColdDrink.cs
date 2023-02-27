using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CP3Me
{
    class ColdDrink : Drink
    {
        bool _hasIce;

        public ColdDrink(string name, decimal price, double points, Size drinkSize, bool hasIce) : base(name, price, points, drinkSize)
        {
            _hasIce = hasIce;
        }

        public override string ToString()
        {
            return base.ToString() + $" - Has Ice {_hasIce}";
        }
    }
}
