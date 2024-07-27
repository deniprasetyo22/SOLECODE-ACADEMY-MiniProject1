using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniProject1
{
    public class Food : MenuItem
    {
        //Properties
        public string Spiciness { get; set; }
        public Food(string name, int price, string description, string spiciness) : base(name, price, description)
        {
            Spiciness = spiciness;
        }

        //Method
        public override int CalculatePrice()
        {
            return Price;
        }

    }
}
