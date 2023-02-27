using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CP3Me
{
    class HotDrink : Drink
    {
        double _temperature;
        public HotDrink(string name, decimal price, double points, Size drinkSize, double temperature) : base(name, price, points, drinkSize)
        {
            _temperature = temperature;
        }

        public override string ToString()
        {
            return base.ToString() + $" - Temperature: {_temperature}";
        }
    }
}
