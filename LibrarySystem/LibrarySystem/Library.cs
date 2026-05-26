using System;
using System.Collections.Generic;
using System.Text;

namespace LibrarySystem
{
    internal class Library
    {
        List<Book> books = new List<Book>();

        public void AddBooks(Book book)
        {
            books.Add(book);
        }

        public void RemoveBooks(Book book)
        {
            books.Remove(book);
        }

        public void SearchBooks(string title)
        {
            foreach (Book book in books)
            {
                if (book.Title == title)
                {
                    Console.WriteLine($"Tittel:  {book.Title}, Forfatter: {book.Author}, Utgivelsesår: {book.Release}");
                }
            }
        }
    }
}
