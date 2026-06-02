using System;
using System.Collections.Generic;
using System.Text;

namespace Fakturasystem
{
    internal class SimpleProduct : Product, Ibillable
    {
        public int antall { get; set; }

        public SimpleProduct(string name, int enhetspris, int antall) : base(name, enhetspris)
        {
            this.antall = antall;
        }

        public decimal GetTotal()
        {
            return Enhetspris * antall;
        }
    }
}
