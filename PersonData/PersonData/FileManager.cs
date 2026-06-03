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
        }

        public List<Person> LoadFromFile()
        {
            try
            {
                List<Person> people = new List<Person>();

                string[] lines = File.ReadAllLines("personer.txt");

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
