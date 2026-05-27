using System;
using System.Collections.Generic;
using System.Runtime.ConstrainedExecution;
using System.Text;

namespace WarehouseAdmin
{
    internal class Warehouse
    {
        List<StockItem> stockItems = new List<StockItem>();

        public void AddStock(StockItem item)
        {
            stockItems.Add(item);
        }
        public void RemoveStock()
        {

            Console.WriteLine("\nHvilket produkt vil du fjerne?");
            string name = Console.ReadLine();

            foreach (StockItem stock in stockItems)
            {
                if (stock.product.Name == name)
                {
                    stockItems.Remove(stock);
                    break;
                }
            }
            
        }
        public void ShowStock()
        {
            Console.WriteLine("--------------Produkter--------------");
            foreach (StockItem item in stockItems)
            {
                Console.WriteLine($"Kodenavn: {item.product.Code}\n" +
                                  $"Navn: {item.product.Name}\n" +
                                  $"Pris: {item.product.Price}\n");
            }
        }
    }
}
