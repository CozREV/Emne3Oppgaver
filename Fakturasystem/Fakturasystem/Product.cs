using System;
using System.Collections.Generic;
using System.Text;

namespace Fakturasystem
{
    internal abstract class Product
    {
        public string Navn { get; set; }
        public int Enhetspris { get; set; }

        public Product(string navn, int enhetspris)
        {
            Navn = navn;
            Enhetspris = enhetspris;
        }

    }
}
