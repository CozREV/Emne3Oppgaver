using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace FoodPaySystem
{
    internal class OrderManager
    {
        List<Order> orders = new List<Order>();

        public void AddOrder(Order order)
        {
            orders.Add(order);
        }

        public void ShowOrders()
        {
            foreach (Order order in orders)
            {
                Console.WriteLine($"Customer: {order.CustomerName}\n" +
                                  $"Pizza Type: {order.PizzaType}\n" +
                                  $"Price: {order.Price}\n" +
                                  $"Time: {order.OrderTime}\n");
            }
        }

        public int GetTotalRevenue()
        {
            return orders.Sum(o => o.Price);
        }

        public List<Order> GetOrdersAfter6PM()
        {
            return orders.Where(o => o.OrderTime.Hour >= 18).ToList();
        }

        public string GetMostPopularPizza()
        {
            var grouped = orders.GroupBy(o => o.PizzaType)
                                .OrderByDescending(g  => g.Count())
                                .First();
            return grouped.Key;
        }
    }
}
