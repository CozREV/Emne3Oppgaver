using System;
using System.Collections.Generic;
using System.Text;

namespace CarRegistry
{
    internal class Car : Vehicle
    {
        public int Seats { get; set; }

        public Car(string brand, string model, int year, int seats) : base(brand, model, year)
        {
            Seats = seats;
        }

        public override string GetInfo()
        {
            return base.GetInfo() + $", Seter: {Seats}";
        }
    }
}
