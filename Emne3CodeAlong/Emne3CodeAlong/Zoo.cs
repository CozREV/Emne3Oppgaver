using System;
using System.Collections.Generic;
using System.Text;

namespace Emne3CodeAlong
{
    internal class Zoo
    {
        public List<Animal> animals = new List<Animal>
        {
            new Animal("Katt", "Mjau"), 
            new Animal("Hund", "Woof"),
            new Animal("Ku", "Moo"),
            new Animal("Sau", "Baa"),
        };
        public void AnimalNoise()
        {
            foreach (Animal animal in animals)
            {
                Console.WriteLine($"Lyd: {animal.Noise}\n");
            }
        }

        public void ListAnimals()
        {
            for (int i = 0; i < animals.Count; i++)
            {
                Console.WriteLine($"{i} - {animals[i].Name}");
            }
        }
    }
}
