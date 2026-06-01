using System;
using System.Collections.Generic;
using System.Text;

namespace CarRegistry
{
    internal abstract class Vehicle
    {
        public string Brand { get; private set; }
        public string Model { get; private set; }
        public int Year { get; private set; }

        public Vehicle(string name, string model, int year)
        {
            Brand = name;
            Model = model;
            Year = year;
        }

        public virtual string GetInfo()
        {
            return $"Merke: {Brand}, Modell: {Model}, År: {Year}";
        }

    }
}
