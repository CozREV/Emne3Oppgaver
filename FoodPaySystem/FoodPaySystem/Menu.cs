using System;
using System.Collections.Generic;
using System.Text;

namespace FoodPaySystem
{
    internal class Menu
    {
        FileManager fileManager = new FileManager();
        OrderManager orderManager = new OrderManager();

        private void AddOrder()
        {
            Console.Write("Pizza type: ");
            string pizzaType = Console.ReadLine();

            Console.Write("Date (15.06.2026 14:30): ");
            DateTime date = Convert.ToDateTime(Console.ReadLine());

            Console.Write("Price: ");
            int price = Convert.ToInt32(Console.ReadLine());

            Console.Write("Your name: ");
            string name = Console.ReadLine();

            Order order = new Order(name, pizzaType, price, date);
            orderManager.AddOrder(order);

        }

        private void ShowOrder()
        {
            orderManager.ShowOrders();
        }

        public void Run()
        {
            bool isTrue = true;

            while (isTrue)
            {
                Console.WriteLine("1. Show all orders\n" +
                                  "2. Add Order\n" +
                                  "3. Load from file\n" +
                                  "4. Save to file\n" +
                                  "5. Total revenue\n" +
                                  "6. Most popular Pizza\n" +
                                  "7. Orders after 6PM\n" +
                                  "8. Avslutt\n");

                string input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        ShowOrder();
                        break;
                        
                    case "2":
                        AddOrder();
                        break;

                    case "3":
                        orderManager.LoadOrders(fileManager.LoadFile());
                        break;

                    case "4":
                        fileManager.SaveFile(orderManager.GetOrders());
                        break;

                    case "5":
                        int revenue = orderManager.GetTotalRevenue();
                        Console.WriteLine($"Total revenue: {revenue}");
                        break;

                    case "6":
                        string popular = orderManager.GetMostPopularPizza();
                        Console.WriteLine($"Most popular pizza: {popular}");
                        break;

                    case "7":
                        List<Order> after6PM = orderManager.GetOrdersAfter6PM();
                        foreach ( Order o in after6PM)
                        {
                            Console.WriteLine($"{o.CustomerName} - {o.PizzaType} - {o.OrderTime}");
                        }
                        break;

                    case "8":
                        isTrue = false;
                        Console.WriteLine("Have a good day");
                        break;
                }
            }
        }
    }
}
