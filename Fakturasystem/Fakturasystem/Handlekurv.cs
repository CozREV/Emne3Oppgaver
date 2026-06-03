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
            Console.WriteLine("------Kvittering------");
            foreach (Ibillable item in cart)
            {
                SimpleProduct simple = item as SimpleProduct;
                WeightedProduct weighted = item as WeightedProduct;

                if (simple != null)
                {
                    Console.WriteLine("Navn: " + simple.Navn);
                    Console.WriteLine($"Antall: {simple.antall}");
                    Console.WriteLine("Pris: " + item.GetTotal());
                }
                else
                {
                    Console.WriteLine("Navn: " + weighted.Navn);
                    Console.WriteLine($"Vekt: {weighted.weight}");
                    Console.WriteLine("Pris: " + item.GetTotal());
                }

                Console.WriteLine();

                total += item.GetTotal();
            }
            Console.WriteLine($"Totalpris: {total}\n");
        }
    }
}
