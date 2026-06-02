using System;
using System.Collections.Generic;
using System.Text;

namespace AnimalSounds
{
    internal class Animal
    {
        public string Name { get; private set; }

        public Animal(string name)
        {
            Name = name;
        }
    }
}
