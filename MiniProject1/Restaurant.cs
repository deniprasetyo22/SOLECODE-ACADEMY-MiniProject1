using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniProject1
{
    public class Restaurant
    {

        //Properties
        public string Name { get; set; }
        public List<MenuItem> Menu { get; set; }
        public List<Order> Orders { get; set; }

        //Constructor
        public Restaurant(string name)
        {
            Name = name;
            Menu = new List<MenuItem>();
            Orders = new List<Order>();
        }

        //Method
        public void AddMenu(MenuItem menu)
        {
            Menu.Add(menu);
        }
        public void ReceiveOrders(Order order)
        {
            Orders.Add(order);
        }
        public int CalculateRevenue()
        {
            int revenue = 0;
            foreach (var order in Orders)
            {
                revenue += order.CalculateTotal();
            }
            return revenue;
        }
    }
}
