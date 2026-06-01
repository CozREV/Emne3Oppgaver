using System;
using System.Collections.Generic;
using System.Text;

namespace Emne3CodeAlong
{
    internal class Menu
    {
        Zoo zoo = new Zoo();
        public void Run()
        {
            bool isTrue = true;

            while (isTrue)
            {
                Console.WriteLine("--------");
                zoo.ListAnimals();

                int input = Convert.ToInt32(Console.ReadLine());

                if (input < zoo.animals.Count)
                {
                    Console.WriteLine($"Lyd: {zoo.animals[input].Noise}");
                }
            }
        }
    }
}
