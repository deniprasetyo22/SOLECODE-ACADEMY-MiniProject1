// See https://aka.ms/new-console-template for more information
using MiniProject1;


OnlineFoodOrderingSystem system = new OnlineFoodOrderingSystem();

// Membuat beberapa objek Restaurant.
Restaurant restaurant1 = new Restaurant("Restoran Satu");
Restaurant restaurant2 = new Restaurant("Restoran Dua");
Restaurant restaurant3 = new Restaurant("Restoran Tiga");

// Menambahkan restoran ke dalam sistem
system.AddRestaurant(restaurant1);
system.AddRestaurant(restaurant2);
system.AddRestaurant(restaurant3);

// Menambahkan berbagai MenuItem ke menu restoran.
Food food1= new Food("Food 1", 12000, "Description Food 1", "Spiciness Food 1");
Beverage beverage1 = new Beverage("Beverage 1", 15000, "Description Beverage 1", "Size Beverage 1");
Dessert dessert1 = new Dessert("Dessert 1", 15000, "Description Desser 1", "Sugar Level Dessert 1");

Food food2 = new Food("Food 2", 5000, "Description Food 2", "Spiciness Food 2");
Beverage beverage2 = new Beverage("Beverage 2", 20000, "Description Beverage 2", "Size Beverage 2");
Dessert dessert2 = new Dessert("Dessert 2", 20000, "Description Desser 2", "Sugar Level Dessert 2");

Food food3 = new Food("Food 3", 20000, "Description Food 2", "Spiciness Food 3");
Beverage beverage3 = new Beverage("Beverage 3", 20000, "Description Beverage 3", "Size Beverage 3");
Dessert dessert3 = new Dessert("Dessert 3", 20000, "Description Desser 3", "Sugar Level Dessert 3");

restaurant1.AddMenu(food1);
restaurant1.AddMenu(beverage1);
restaurant1.AddMenu(dessert1);

restaurant2.AddMenu(food2);
restaurant2.AddMenu(beverage2);
restaurant2.AddMenu(dessert2);

restaurant3.AddMenu(food3);
restaurant3.AddMenu(beverage3);
restaurant3.AddMenu(dessert3);

// Mensimulasikan proses pemesanan
List<MenuItem> orderedItems1 = new List<MenuItem> { food1, beverage1, dessert1 };
int orderNumber1 = system.PlaceOrder("Restoran satu", orderedItems1);

List<MenuItem> orderedItems2 = new List<MenuItem> { food2, beverage2, dessert2 };
int orderNumber2 = system.PlaceOrder("Restoran Dua", orderedItems2);

List<MenuItem> orderedItems3 = new List<MenuItem> { food3, beverage3, dessert3 };
int orderNumber3 = system.PlaceOrder("Restoran Tiga", orderedItems3);

// Menampilkan detail order
system.DisplayOrderDetails(orderNumber1);
system.DisplayOrderDetails(orderNumber2);
system.DisplayOrderDetails(orderNumber3);

//Membatalkan order
system.CancelOrder(orderNumber1);
system.DisplayOrderDetails(orderNumber1);

//Menampilkan status order
Console.WriteLine(system.GetOrderStatus(orderNumber1));
Console.WriteLine("----------------------------------------------");
Console.WriteLine(system.GetOrderStatus(orderNumber2));
Console.WriteLine("----------------------------------------------");
Console.WriteLine(system.GetOrderStatus(orderNumber3));
Console.WriteLine("----------------------------------------------");
