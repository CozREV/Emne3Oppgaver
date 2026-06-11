using System;
using System.Collections.Generic;
using System.Security.AccessControl;
using System.Text;

namespace PersonData
{
    internal class Menu
    {
        List<Person> people = new List<Person>();
        PersonRegistry registry = new PersonRegistry();
        FileManager manager = new FileManager();

        private void AddPerson()
        {
            Console.WriteLine("------Legg til person------");
            Console.Write("Navn: ");
            string name = Console.ReadLine();
            Console.Write("Alder: ");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.Write("Email: ");
            string email = Console.ReadLine();

            Person person = new Person(name, age, email);
            registry.AddPeople(person);
        }

        private void ShowPerson()
        {
            registry.ShowPerson();
        }

        public void Run()
        {

            bool isTrue = true;

            while (isTrue)
            {
                Console.WriteLine("------Hovedside------");
                Console.WriteLine("1. Legg til person\n" +
                                  "2. Vis personer\n" +
                                  "3. Lagre til fil\n" +
                                  "4. Laste fra fil\n" +
                                  "5. Avslutt\n");

                string input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        AddPerson();
                        break;
                    case "2":
                        ShowPerson();
                        break;
                    case "3":
                        manager.SaveToFile(registry.GetPeople());
                        break;
                    case "4":
                        registry.LoadPeople(manager.LoadFromFile());
                        break;
                    case "5":
                        isTrue = false;
                        Console.WriteLine("Ha en fin dag");
                        break;
                }
            }
        }
    }
}
