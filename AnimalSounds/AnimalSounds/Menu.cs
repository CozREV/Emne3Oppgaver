using System;
using System.Collections.Generic;
using System.Text;

namespace AnimalSounds
{
    internal class Menu
    {
        public void Run()
        {
            List<ISound> Asounds = new List<ISound>()
            {
                new Dog(),
                new Cat(),
                new Cow()
            };

            foreach (ISound sound in Asounds)
            {
                    sound.MakeSound();
            }
        }
    }
}
