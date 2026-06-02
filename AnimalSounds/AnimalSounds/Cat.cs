using System;
using System.Collections.Generic;
using System.Text;

namespace AnimalSounds
{
    internal class Cat : Animal, ISound
    {
        public Cat() : base("Cat"){ }
        public void MakeSound()
        {
            Console.WriteLine("Mjau");
        }
    }
}
