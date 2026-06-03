using System;
using System.Collections.Generic;
using System.Text;

namespace PersonData
{
    internal class PersonRegistry
    {
        List<Person> person = new List<Person>();

        public void AddPeople(Person people)
        {
            person.Add(people);
        }
        public List<Person> GetPeople()
        {
            return person;
        }

        public void LoadPeople(List<Person> people)
        {
            person = people;
        }

        public void ShowPerson()
        {
            foreach (Person people in person)
            {
                Console.WriteLine($"Navn: {people.Name}\n" +
                                  $"Alder: {people.Age}\n" +
                                  $"Email: {people.Email}\n");
            }
        }
    }
}
