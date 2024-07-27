using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniProject1
{
    public interface IOrderingSystem
    {
        void AddRestaurant(Restaurant restaurant);
        int PlaceOrder(string restaurantName, List<MenuItem> orderedItems);
        void DisplayOrderDetails(int orderNumber);
        void CancelOrder(int orderNumber);
        string GetOrderStatus(int orderNumber);

    }
}
