using System;
using System.Collections.Generic;
using System.Text;

namespace Emne3CodeAlong
{
    internal class Animal
    {
        public string Name { get; set; }
        public string Noise { get; set; } 
            
        public Animal(string name, string noise)
        {
            Name = name;
            Noise = noise;
        }
    }
}
