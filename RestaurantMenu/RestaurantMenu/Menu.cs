using System;
using System.Collections.Generic;
using System.Text;

namespace RestaurantMenu
{
    internal class Menu
    {
        List<MenuItem> items = new List<MenuItem>();

        public void MenuChoice(MenuItem item)
        {
            items.Add(item);
        }

        public void MenuCatFilter(string category)
        {
            Console.WriteLine("------Filtrert mat------");
            foreach (MenuItem item in items)
            {
                if (item.Category == category)
                {
                    Console.WriteLine($"Navn: {item.Name}\n" +
                                      $"Kategori: {item.Category}\n" +
                                      $"Pris: {item.Price}\n");
                }
            }
        }

        public void MenuCheapFilter()
        {
            MenuItem cheapest = items[0];

            foreach (MenuItem item in items)
            {
                if (item.Price < cheapest.Price)
                {
                    cheapest = item;
                }
            }

            Console.WriteLine(cheapest.Name + " - " + cheapest.Price);
        }

        public void MenuExpensiveFilter()
        {
            MenuItem expensive = items[0];

            foreach (MenuItem item in items)
            {
                if (item.Price > expensive.Price)
                {
                    expensive = item;
                }
            }

            Console.WriteLine(expensive.Name + " - " + expensive.Price);
        }

        public void TotalPrice()
        {
            int total = 0;

            foreach (MenuItem item in items)
            {
                total += item.Price;
            }
            Console.WriteLine(total);
        }
    }
}
