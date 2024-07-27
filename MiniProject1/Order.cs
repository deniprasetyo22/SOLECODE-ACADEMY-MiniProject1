using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniProject1
{
    public class Order
    {
        public int OrderNumber { get; set; }
        public List<MenuItem> OrderedItems { get; set; }

        public Order(int orderNumber)
        {
            OrderNumber = orderNumber;
            OrderedItems = new List<MenuItem>();
        }
        public int CalculateTotal()
        {
            int total = 0;
            foreach (MenuItem menu in OrderedItems)
            {
                total += menu.CalculatePrice();
            }
            return total;
        }

        //tambah addmenu
        public void AddMenuItem(MenuItem menuItem)
        {
            OrderedItems.Add(menuItem);
        }


    }
}
