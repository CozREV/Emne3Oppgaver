using System;
using System.Collections.Generic;
using System.Text;

namespace FoodPaySystem
{
    internal class Order
    {
        public string CustomerName { get; private set; }
        public string PizzaType { get; private set; }
        public int Price { get; private set; }
        public DateTime OrderTime { get; private set; }

        public Order(string customerName, string pizzaType, int price, DateTime orderTime)
        {
            CustomerName = customerName;
            PizzaType = pizzaType;
            Price = price;
            OrderTime = orderTime;
        }
    }
}
