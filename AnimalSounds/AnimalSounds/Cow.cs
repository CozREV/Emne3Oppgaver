using System;
using System.Collections.Generic;
using System.Text;

namespace AnimalSounds
{
    internal class Cow : Animal, ISound
    {
        public Cow() : base("Cow"){ }

        public void MakeSound()
        {
            Console.WriteLine("Cow");
        }
    }
}
