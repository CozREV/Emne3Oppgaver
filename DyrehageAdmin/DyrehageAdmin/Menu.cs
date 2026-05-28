using System;
using System.Collections.Generic;
using System.Text;

namespace DyrehageAdmin
{
    internal class Menu
    {
            Zoo zoo = new Zoo();

        private void AddAnimal()
        {
            Animal animal = new Animal();

            Console.WriteLine("-------Legg til dyr-------");
            Console.Write("Skriv navn: ");
            animal.Name = Convert.ToString(Console.ReadLine());

            Console.Write("Skriv art: ");
            animal.Art = Convert.ToString(Console.ReadLine());

            Console.Write("Skriv alder: ");
            animal.Age = Convert.ToInt32(Console.ReadLine());

            zoo.AddAnimal(animal);
        }

        private void RemoveAnimal()
        {
            Console.WriteLine("-------fjern til dyr-------");
            Console.WriteLine("Skriv navnet til dyret du vil fjerne: ");
            string name = Console.ReadLine();

            zoo.RemoveAnimal(name);
        }

        public void Run()
        {
            bool isTrue = true;
            
            while (isTrue)
            {
                Console.WriteLine("-------Hovedside-------");
                Console.WriteLine("1. Legg til dyr\n" +
                                  "2. Fjern dyr\n" +
                                  "3. Vis dyr\n" +
                                  "4. Søk etter dyr\n" +
                                  "5. Avslutt\n");

                string input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        AddAnimal();
                        break;
                    case "2":
                        RemoveAnimal();
                        break;
                    case "3":
                        zoo.ShowAnimal();
                        break;
                    case "4":
                        zoo.SearchAnimal();
                        break;
                    default:
                        isTrue = false;
                        Console.WriteLine("\nHa en fin dag!");
                        break;
                }

            }
        }
    }
}
