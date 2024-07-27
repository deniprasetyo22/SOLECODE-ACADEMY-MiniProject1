using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniProject1
{
    public class Dessert : MenuItem
    {
        //Properties
        public string SugarLevel { get; set; }
        public Dessert(string name, int price, string description, string sugarLevel) : base(name, price, description)
        {
            SugarLevel = sugarLevel;
        }

        //Method
        public override int CalculatePrice()
        {
            return Price;
        }

    }
}
