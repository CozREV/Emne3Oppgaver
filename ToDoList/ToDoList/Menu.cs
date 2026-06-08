using System;
using System.Collections.Generic;
using System.Text;

namespace ToDoList
{
    internal class Menu
    {
        public void Run()
        {
            bool isTrue = true;

            while (isTrue)
            {
                Console.WriteLine("1. Legg til Oppgave\n" +
                                  "2. Vis alle Oppgaver\n" +
                                  "3. Vis uløste oppgaver\n" +
                                  "4. Søk etter oppgave\n" +
                                  "5. Fullfør en oppgave\n" +
                                  "6. Tell fullførte oppgaver\n" +
                                  "7. Lagre til fil\n" +
                                  "8. Last fra fil\n" +
                                  "9. Avslutt\n");

                string input = Console.ReadLine();

                switch (input)
                {
                    case "1":

                        break;
                    case "2":

                        break;
                    case "3":

                        break;
                    case "4":

                        break;
                    case "5":

                        break;
                    case "6":

                        break;
                    case "7":

                        break;
                    case "8":

                        break;
                    case "9":

                        break;
                }
            }
        }
    }
}
