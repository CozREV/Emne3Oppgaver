using System;
using System.Collections.Generic;
using System.Text;

namespace PersonData
{
    internal class Person
    {
        public string Name { get; private set; }
        public int Age { get; private set; }
        public string Email { get; private set; }
        
        public Person(string name, int age, string email)
        {
            Name = name;
            Age = age;
            Email = email;
        }

    }
}
