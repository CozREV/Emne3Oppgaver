using System;
using System.Collections.Generic;
using System.Text;

namespace PersonData
{
    internal class FileManager
    {
        public void SaveToFile(List<Person> people)
        {
            List<string> lines = new List<string>();

            foreach (Person person in people)
            {
                lines.Add($"{person.Name},{person.Age},{person.Email}");
            }

            File.WriteAllLines("personer.txt", lines);
            Console.WriteLine("Lagret til fil \n");
        }

        public List<Person> LoadFromFile()
        {
            try
            {
                List<Person> people = new List<Person>();

                string[] lines = File.ReadAllLines("personer.txt");

                Console.WriteLine("Lastet fra fil \n");

                foreach (string line in lines)
                {
                    string[] parts = line.Split(',');
                    Person person = new Person(parts[0], Convert.ToInt32(parts[1]), parts[2]);
                    people.Add(person);
                }

                return people;
            }
            catch (Exception e)
            {
                return new List<Person>();
            }
        }
    }
}
