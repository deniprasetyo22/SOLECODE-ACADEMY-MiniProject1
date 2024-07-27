using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniProject1
{
    public class OnlineFoodOrderingSystem : IOrderingSystem
    {

        private List<Restaurant> restaurants;
        private int nextOrderNumber;

        public OnlineFoodOrderingSystem()
        {
            restaurants = new List<Restaurant>();
            nextOrderNumber = 1;
        }

        public void AddRestaurant(Restaurant restaurant)
        {
            restaurants.Add(restaurant);
        }

        public int PlaceOrder(string restaurantName, List<MenuItem> orderedItems)
        {
            Restaurant restaurant = restaurants.Find(cek => cek.Name.Equals(restaurantName, StringComparison.OrdinalIgnoreCase));
            if (restaurant == null)
            {
                Console.WriteLine("Restaurant tidak ditemukan.");
                Console.WriteLine("----------------------------------------------");
                return -1;
            }

            Order order = new Order(nextOrderNumber++);
            foreach (MenuItem item in orderedItems)
            {
                item.CalculatePrice();
                order.OrderedItems.Add(item);
            }

            restaurant.Orders.Add(order);
            Console.WriteLine($"Order berhasil dibuat dengan nomor order: {order.OrderNumber}");
            Console.WriteLine("----------------------------------------------");
            return order.OrderNumber;
        }

        public void DisplayOrderDetails(int orderNumber)
        {
            foreach (Restaurant restaurant in restaurants)
            {
                Order order = restaurant.Orders.Find(cek => cek.OrderNumber == orderNumber);
                if (order != null)
                {
                    Console.WriteLine($"Detail Order Nomor: {order.OrderNumber}");
                    foreach (var item in order.OrderedItems)
                    {
                        Console.WriteLine($"Item: {item.Name}, Harga: {item.Price}");
                    }
                    Console.WriteLine($"Total Harga: {order.CalculateTotal()}");
                    Console.WriteLine("----------------------------------------------");
                    return;
                }
            }
            Console.WriteLine($"Order dengan order nomor {orderNumber} tidak ditemukan.");
            Console.WriteLine("----------------------------------------------");
        }

        public void CancelOrder(int orderNumber)
        {
            foreach (Restaurant restaurant in restaurants)
            {
                Order order = restaurant.Orders.Find(cek => cek.OrderNumber == orderNumber);
                if (order != null)
                {
                    restaurant.Orders.Remove(order);
                    Console.WriteLine($"Order nomor {orderNumber} telah dibatalkan.");
                    return;
                }
            }
            Console.WriteLine($"Order dengan norder nomor {orderNumber} tidak ditemukan.");
            Console.WriteLine("----------------------------------------------");
        }

        public string GetOrderStatus(int orderNumber)
        {
            foreach (Restaurant restaurant in restaurants)
            {
                Order order = restaurant.Orders.Find(cek => cek.OrderNumber == orderNumber);
                if (order != null)
                {
                    return $"Order dengan order number {orderNumber} sedang diproses";
                }
                else { 
                }
            }
            return $"Order dengan order number {orderNumber} tidak ditemukan";
        }
    }
}
