using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniProject1
{
    public class Beverage : MenuItem
    {
        //Properties
        public string Size { get; set; }
        public Beverage(string name, int price, string description, string size) : base(name, price, description)
        {
            Size = size;
        }

        //Method
        public override int CalculatePrice()
        {
            return Price;
        }

    }
}
