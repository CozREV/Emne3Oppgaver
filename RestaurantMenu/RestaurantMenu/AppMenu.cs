using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Channels;

namespace RestaurantMenu
{
    internal class AppMenu
    {
        Menu menu = new Menu();

        private void AddItem()
        {
            MenuItem item = new MenuItem();

            Console.WriteLine("------Legg til mat------");

            Console.Write("Navn: ");
            item.Name = Console.ReadLine();

            Console.Write("Kategori: ");
            item.Category = Console.ReadLine();

            Console.Write("Pris: ");
            item.Price = Convert.ToInt32(Console.ReadLine());

            menu.MenuChoice(item);
        }

        private void FilterCategory()
        {
            Console.WriteLine("------Filter------");
            Console.Write("Kategori: ");
            menu.MenuCatFilter(Console.ReadLine());
        }

        public void Run()
        {

            bool isTrue = true;

            while(isTrue)
            {
                Console.WriteLine("------Hovedmeny------");
                Console.WriteLine("1. Legg til mat\n" +
                                  "2. Mat kategori filter\n" +
                                  "3. Finn billigste mat\n" +
                                  "4. Finn dyreste mat\n" +
                                  "5. Totalprisen\n" +
                                  "6. Avslutt\n");

                String input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        AddItem();
                        break;
                    case "2":
                        FilterCategory();
                        break;
                    case "3":
                        menu.MenuCheapFilter();
                        break;
                    case "4":
                        menu.MenuExpensiveFilter();
                        break;
                    case "5":
                        menu.TotalPrice();
                        break;
                    case "6":
                        isTrue = false;
                        Console.WriteLine("Ha en fin dag");
                        break;
                }
            }
        }
    }
}
