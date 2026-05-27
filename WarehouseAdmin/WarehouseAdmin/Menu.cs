using System;
using System.Collections.Generic;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Channels;

namespace WarehouseAdmin
{
    internal class Menu
    {
        Warehouse warehouse = new Warehouse();

        private void AddProduct()
        {
            Product product = new Product();
            StockItem stockItem = new StockItem();

            Console.WriteLine("--------Skriv inn detaljer her--------");
            Console.Write("Kode: ");
            product.Code = Convert.ToString(Console.ReadLine());

            Console.Write("Navn: ");
            product.Name = Convert.ToString(Console.ReadLine());

            Console.Write("Pris: ");
            product.Price = Convert.ToInt32(Console.ReadLine());

            Console.Write("Antall: \n");
            stockItem.Quantity = Convert.ToInt32(Console.ReadLine());

            stockItem.product = product;
            warehouse.AddStock(stockItem);
        }

        private void RemoveProduct()
        {
            warehouse.RemoveStock();
        }

        private void ShowProduct()
        {
            warehouse.ShowStock();
        }


        public void Run()
        {

            bool isTrue = true;

            while (isTrue)
            {
                Console.WriteLine("--------------Hovedmeny--------------");
                Console.WriteLine("1. Legg til produkt\n" +
                                  "2. Fjern produkt\n" +
                                  "3. Vis produkt\n" +
                                  "4. Avslutt");

                string input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        AddProduct();
                        break;

                    case "2":
                        RemoveProduct();
                        break;

                    case "3":
                        ShowProduct();
                        break;

                    default:
                        isTrue = false;
                        Console.WriteLine("Ha en fin dag");
                        break;
                }
            
            }
        }
    }
}
