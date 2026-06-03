using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Fakturasystem
{
    internal class Menu
    {
        Handlekurv handlekurv = new Handlekurv();

        private void AddSimpleProduct()
        {
            Console.WriteLine("------Legg til produkt------");
            Console.Write("Navn på produktet: ");
            string navn = Console.ReadLine();
            Console.Write("Enhetspris på produktet: ");
            int enhetspris = Convert.ToInt32(Console.ReadLine());
            Console.Write("antall: ");
            int antall = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();

            SimpleProduct product = new SimpleProduct(navn, enhetspris, antall);
            handlekurv.AddProduct(product);

        }

        private void AddWeightedProduct()
        {
            Console.WriteLine("------Legg til produkt------");
            Console.Write("Navn på produktet: ");
            string navn = Console.ReadLine();
            Console.Write("Enhetspris på produktet: ");
            int enhetspris = Convert.ToInt32(Console.ReadLine());
            Console.Write("Vekt (kilogram): ");
            double vekt = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();

            WeightedProduct product = new WeightedProduct(navn, enhetspris, vekt);
            handlekurv.AddProduct(product);
        }

        public void ShowReceipt()
        {
            handlekurv.PrintReceipt();
        }

        public void Run()
        {
            bool isTrue = true;


            while (isTrue)
            {
                Console.WriteLine("------Hovedside------");
                Console.WriteLine("1. Legg til enkelt produkt\n" +
                                  "2. Legg til vekt produkt\n" +
                                  "3. Vis kvittering\n" +
                                  "4. Avslutt\n");

                string input = Console.ReadLine();

                switch (input) 
                {
                    case "1":
                        AddSimpleProduct();
                        break;
                    case "2":
                        AddWeightedProduct();
                        break;
                    case "3":
                        ShowReceipt();
                        break;
                    case "4":
                        isTrue = false;
                        Console.WriteLine("Ha en fin dag");
                        break;
                }

                
            }
        }

    }
}
