using System;
using System.Collections.Generic;
using System.Text;

namespace Fakturasystem
{
    internal class WeightedProduct : Product, Ibillable
    {
        public int weight { get; set; }

        public WeightedProduct(string name, int enhetspris, int weight) : base(name, enhetspris)
        {
            this.weight = weight;
        }

        public decimal GetTotal()
        {
            return Enhetspris * weight;
        }
    }
}
