using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CP3Me
{
    // Abstract Child Class Inheritting from parent main Product Abstract class
    abstract class Drink : Product
    {
        public enum Size { Tall, Grande, Venti, Trenta }

        Size _drinkSize;

        public Drink(string name, decimal price, double points, Size drinkSize) : base(name, price, points)
        {
            _drinkSize = drinkSize;
        }
        public Size DrinkSize
        {
            get => _drinkSize;
        }

        // Override the ToString()

        public override string ToString()
        {
            return base.ToString() + $" - Drink Size: {_drinkSize.ToString()}";
        }

        /*
        public override bool InStock()
        {
            if (DrinkSize <= Size.Venti) return false;
            return true;
        }
        */

    }
}
