using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using System.Text;

namespace FIlmCatalog
{
    internal class Menu
    {
        Catalog catalog = new Catalog();

        private void AddMovie()
        {
            Movie movie = new Movie();

            Console.WriteLine("------Legg til film------");
            Console.Write("Film Tittel: ");
            movie.Title = Console.ReadLine();

            Console.Write("Film Sjanger: ");
            movie.Genre = Console.ReadLine();

            Console.Write("Film Lengde: ");
            movie.Time = Convert.ToInt32(Console.ReadLine());

            catalog.AddMovie(movie);
        }

        public void Run()
        {
            bool isTrue = true;

            while (isTrue)
            {
                Console.WriteLine("------Hovedmeny------");
                Console.WriteLine("1. Legg til film\n" +
                                  "2. Sorter lengde på film\n" +
                                  "3. Søk med sjanger\n" +
                                  "4. Sorter Tittel\n" +
                                  "5. Bruker Rating\n" +
                                  "6. Top tre filmer\n" +
                                  "7. Avslutt\n");

                string input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        AddMovie();
                        break;
                    case "2":
                        Console.WriteLine("------Film lengde------");
                        Console.Write("Minimum lengde: ");
                        int length = Convert.ToInt32(Console.ReadLine());
                        catalog.FindMovieByLength(length);
                        break;
                    case "3":
                        Console.WriteLine("------Søk etter sjanger------");
                        Console.Write("Søk sjanger: ");
                        string genre = Console.ReadLine();
                        catalog.SearchGenre(genre);
                        break;
                    case "4":
                        catalog.SortByTitle();
                        break;
                    case "5":
                        catalog.UserRating();
                        break;
                    case "6":
                        catalog.TopThree();
                        break;
                    case "7":
                        isTrue = false;
                        Console.WriteLine("Ha en fin dag");
                        break;
                }

            }
        }
    }
}
