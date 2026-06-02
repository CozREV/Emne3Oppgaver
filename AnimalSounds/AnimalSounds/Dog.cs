using System;
using System.Collections.Generic;
using System.Text;

namespace AnimalSounds
{
    internal class Dog : Animal, ISound
    {
        public Dog() : base("Dog"){ }
        public void MakeSound()
        {
            Console.WriteLine("Woof");
        }
    }
}
