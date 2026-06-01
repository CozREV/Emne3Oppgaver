using System;
using System.Collections.Generic;
using System.Text;

namespace CarRegistry
{
    internal class Registry
    {
        public List<Vehicle> vehicles = new List<Vehicle>();

        public void AddVehicle(Vehicle vehicle)
        {
            vehicles.Add(vehicle);
        }

        public void RemoveVehicle(Vehicle vehicle)
        {
            vehicles.Remove(vehicle);
        }
        public void ShowVehicle()
        {
            for (int i = 0;  i < vehicles.Count; i++)
            {
                Console.WriteLine($"{i} - {vehicles[i].GetInfo()}");
            }
        }
    }
}
