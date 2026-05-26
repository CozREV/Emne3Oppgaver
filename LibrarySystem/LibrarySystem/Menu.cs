using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Channels;

namespace LibrarySystem
{
    internal class Menu
    {
        public void Run()
        {

            Library library = new Library();
            
            bool isTrue = true;

            while (isTrue)
            {
                Book book = new Book();

                Console.Write("Book Title: ");
                book.Title = Convert.ToString(Console.ReadLine());

                Console.Write("Book Author: ");
                book.Author = Convert.ToString(Console.ReadLine());

                Console.Write("Book Release Year: ");
                book.Release = Convert.ToInt32(Console.ReadLine());

                library.AddBooks(book);

                Console.WriteLine("Search for your book: ");
                string searchTitle = Console.ReadLine();
                library.SearchBooks(searchTitle);

                Console.WriteLine("Want to add another book? (Y/N)");
                string response = Console.ReadLine();
                response = response.ToUpper();

                if (response == "Y")
                {
                    isTrue = true;
                }
                else
                {
                    isTrue = false;
                    Console.WriteLine("Thanks for testing");
                }
    

            }
        }
    }
}
