using Microsoft.Win32.SafeHandles;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Threading.Channels;

namespace CarRegistry
{
    internal class Menu
    {
        Registry registry = new Registry();

        private void AddVehicle()
        {
            Console.WriteLine("1. Bil\n" +
                              "2. Motorsykkel\n");

            string type = Console.ReadLine();

            if (type == "1")
            {

                Console.Write("Merke: ");
                string brand = Console.ReadLine();

                Console.Write("Modell: ");
                string model = Console.ReadLine();

                Console.Write("År: ");
                int year = Convert.ToInt32(Console.ReadLine());

                Console.Write("Seter: ");
                int seats = Convert.ToInt32(Console.ReadLine());

                Car car = new Car(brand, model, year, seats);
                registry.AddVehicle(car);
            }
            else
            {
                Console.Write("Merke: ");
                string brand = Console.ReadLine();

                Console.Write("Modell: ");
                string model = Console.ReadLine();

                Console.Write("År: ");
                int year = Convert.ToInt32(Console.ReadLine());

                Console.Write("Sidevogn: ");
                bool sidecar = Console.ReadLine() == "Y";

                Motorcycle motorcycle = new Motorcycle(brand, model, year, sidecar);
                registry.AddVehicle(motorcycle);
            }
        }

        private void RemoveVehicle()
        {
            Console.Write("Skriv modell du vil fjerne: ");
            string model = Console.ReadLine();

            foreach (Vehicle vehicle in registry.vehicles)
            {
                if (vehicle.Model == model)
                {
                    registry.RemoveVehicle(vehicle);
                    break;
                }

            }
        }

        public void Run()
        {
            bool isTrue = true;

            Console.WriteLine("------Hovedside------");

            while (isTrue)
            {
                Console.WriteLine("A. Legg til\n" +
                                  "R. Fjern\n" +
                                  "S. Vis\n" +
                                  "Q. Avslutt\n");

                string input = Console.ReadLine();
                input = input.ToUpper();

                switch (input)
                {
                    case "A":
                        AddVehicle();
                        break;
                    case "R":
                        RemoveVehicle();
                        break;
                    case "S":
                        registry.ShowVehicle();
                        break;
                    case "Q":
                        isTrue = false;
                        Console.WriteLine("Ha en fin dag");
                        break;
                }
            }
        }
    }
}
