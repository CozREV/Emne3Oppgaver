using System;
using System.Collections.Generic;
using System.Text;

namespace CarRegistry
{
    internal class Motorcycle : Vehicle
    {
        public bool Sidecar { get; set; }

        public Motorcycle(string name, string model, int year, bool sidecar) : base(name, model, year)
        {
            Sidecar = sidecar;
        }

        public override string GetInfo()
        {
            return base.GetInfo() + $", Sidevogn: {Sidecar}";
        }
    }
}
