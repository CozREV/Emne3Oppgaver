using System;
using System.Collections.Generic;
using System.Text;

namespace FIlmCatalog
{
    internal class Catalog
    {
        List<Movie> movies = new List<Movie>();

        public void AddMovie(Movie movie)
        {
            movies.Add(movie);
        }
        public void FindMovieByLength(int length)
        {
            Console.WriteLine("\n------Filmer------");

            foreach (Movie movie in movies)
            {
                if (movie.Time >= length)
                {
                    Console.WriteLine($"Navn: {movie.Title}\n" +
                                      $"Sjanger: {movie.Genre}\n" +
                                      $"Duration: {movie.Time}\n");
                }
            }
        }

        public void SearchGenre(string genre)
        {
            Console.WriteLine("\n------Sjanger------");
            foreach (Movie movie in movies)
            {
                if (movie.Genre == genre)
                {
                    Console.WriteLine($"Navn: {movie.Title}\n" +
                                      $"Sjanger: {movie.Genre}\n" +
                                      $"Duration: {movie.Time}\n");
                }
            }
        }

        public void SortByTitle()
        {
            Console.WriteLine("\n------Filmer------");
            movies.Sort((a, b) => string.Compare(a.Title, b.Title));

            foreach (Movie movie in movies)
            {
                Console.WriteLine(movie.Title);
            }

            Console.WriteLine();
        }

        public void UserRating()
        {
            Console.WriteLine("------Bruker Rating------");
            Console.Write("Skriv filmtittel: ");
            string title = Console.ReadLine();

            foreach (Movie movie in movies)
            {
                if (movie.Title == title)
                {
                    Console.Write("Gi filmen en rating (1/5): ");
                    movie.Rating = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine();
                    break;
                }
            }
        }

        public void TopThree()
        {
            Console.WriteLine("------Top 3 filmer------");
            movies.Sort();
            

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(movies[i].Title + " - " + movies[i].Rating);
            }
        }
    }
}
