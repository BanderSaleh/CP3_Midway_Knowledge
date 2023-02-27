using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CP3Me
{
    // Defined this Parent Abstract Class to store our apps base Product data.
    //An Abstract class is used to create a general class that others can inherit from,
    //but you can't make a current instance of directly.
    public class Product
    {
        // Fields
        string _name;
        double _price;
        double _points;


        // Constructors
        public Product(string name, double price, double points)
        {
            _name = name;
            _price = price;
            _points = points;
        }

        // Properties
        public string Name
        {
            get => _name;
        }

        internal static void Add(Product products)
        {
            throw new NotImplementedException();
        }

        // override
        public override string ToString()
        {
            //returns a string to override
            return $"{_name} - ${_price} - Points {_points}";
        }


    }
}
