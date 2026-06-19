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
                                  "5. Revenue\n" +
                                  "6. Avslutt\n");

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

                        break;

                    case "4":

                        break;

                    case "5":

                        break;
                    case "6":
                        isTrue = false;
                        Console.WriteLine("Have a good day");
                        break;
                }
            }
        }
    }
}
