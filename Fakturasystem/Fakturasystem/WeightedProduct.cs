using System;
using System.Collections.Generic;
using System.Text;

namespace Fakturasystem
{
    internal class WeightedProduct : Product, Ibillable
    {
        public double weight { get; set; }

        public WeightedProduct(string name, int enhetspris, double weight) : base(name, enhetspris)
        {
            this.weight = weight;
        }

        public decimal GetTotal()
        {
            return Enhetspris * Convert.ToDecimal(weight);
        }
    }
}
