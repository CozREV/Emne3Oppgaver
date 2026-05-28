using System;
using System.Collections.Generic;
using System.Text;

namespace DyrehageAdmin
{
    internal class Zoo
    {
        List<Animal> animals = new List<Animal>();

        public void AddAnimal(Animal animal)
        {
            animals.Add(animal);
        }

        public void RemoveAnimal(string name)
        {
            foreach (Animal a in animals)
            {
                if (a.Name == name)
                {
                    animals.Remove(a);
                    break;
                }
            }
        }

        public void ShowAnimal()
        {
            Console.WriteLine("--------Dine Dyr--------");

            foreach (Animal animal in animals)
            {
                Console.WriteLine($"Navn: {animal.Name}\n" +
                                  $"Art: {animal.Art}\n" +
                                  $"Alder: {animal.Age}\n");

            }
        }

        public void SearchAnimal()
        {
            Console.WriteLine("Søk etter dyre-art: ");
            string Search = Console.ReadLine();

            Console.WriteLine("--------Dine Dyr--------");

            foreach (Animal animal in animals)
            {
                if (animal.Art == Search)
                {
                    Console.WriteLine($"Navn: {animal.Name}\n" +
                                      $"Art: {animal.Art}\n" +
                                      $"Alder: {animal.Age}\n");
                }
            }
        }
    }
}
