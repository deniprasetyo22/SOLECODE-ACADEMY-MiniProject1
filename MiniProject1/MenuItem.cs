using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniProject1
{
    public abstract class MenuItem
    {
        //Properties
        public string Name { get; set; }
        public int Price { get; set; }
        public string Description { get; set; }
        public MenuItem(string name, int price, string description)
        {
            Name = name;
            Price = price;
            Description = description;
        }

        //Method
        public abstract int CalculatePrice();
    }
}
