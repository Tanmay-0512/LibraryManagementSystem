using System;
using System.Collections.Generic;
using LibraryManagementSystem.Models;

namespace LibraryManagementSystem.Services
{
    public class Library
    {
        private List<Book> books = new List<Book>();

        // Add book to library
        public void AddBook(Book book)
        {
            books.Add(book);
            Console.WriteLine("Book added successfully.");
        }

        // Remove book by ISBN
        public void RemoveBook(string isbn)
        {
            books.RemoveAll(book => book.ISBN == isbn);
            Console.WriteLine($"Book with ISBN {isbn} removed.");
        }

        // Search for a book by title
        public Book SearchByTitle(string title)
        {
            return books.Find(book => book.Title.Equals(title, StringComparison.OrdinalIgnoreCase));
        }

        // List all books
        public void ListBooks()
        {
            if (books.Count == 0)
            {
                Console.WriteLine("No books available.");
                return;
            }
            books.ForEach(book => Console.WriteLine(book));
        }
    }
}
