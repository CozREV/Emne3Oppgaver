using System;
using System.Collections.Generic;
using System.Text;

namespace Fakturasystem
{
    internal class Handlekurv
    {
        List<Ibillable> cart = new List<Ibillable>();

        public void AddProduct(Ibillable ibillable)
        {
            cart.Add(ibillable);
        }

        public void PrintReceipt()
        {
            decimal total = 0;
            foreach (Ibillable item in cart)
            {
                Product product = item as Product;
                Console.WriteLine(product.Navn);
                Console.WriteLine(item.GetTotal());
                total += item.GetTotal();
            }
            Console.WriteLine(total);
        }
    }
}
