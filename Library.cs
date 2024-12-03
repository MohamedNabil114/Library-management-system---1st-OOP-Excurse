using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_management_system_project
{
    internal class Library
    {
        public Library(string libName)
        {
            LibraryName = libName;
            books = new List<Book>();
            borrowedBooks = new List<Book>();
        }

        public string LibraryName { get; set; }
        private List<Book> books;  
        private List<Book> borrowedBooks;  
        private const int MaxborrowBooksLimit = 100;

        public void Add(Book book)
        {
            books.Add(book);
            Console.WriteLine("\nBook added successfully.");
        }

        public void Delete(Book book) // يوجد مشكلة في الماتش بين الكتب
        {
            if (books.Contains(book))
            {
                books.Remove(book);
                Console.WriteLine("\nBook deleted.");
            }
            else
            {
                Console.WriteLine("\nBook not found.");
            }
        }

        public void Display()  // يوجد مشكلة In Console user can't add book then the list is empty
        {
            if (books.Count == 0)
            {
                Console.WriteLine("No books available.");
                return;
            }

            Console.WriteLine("The book list:");
            foreach (var book in books)
            {
                Console.WriteLine($"Title: {book.Title}, Author: {book.Author}, Year: {book.Year}");
            }
        }

        public void Borrow(Book book)
        {
            if (borrowedBooks.Count >= MaxborrowBooksLimit)
            {
                Console.WriteLine("Sorry, the library has reached its maximum borrowing limit.");
                return;
            }

            borrowedBooks.Add(book);
            books.Remove(book);
            Console.WriteLine("\nBook borrowed successfully.");
        }

        public void ReturnBook(Book book)  /// يوجد مشكلة logically
        {
            if (borrowedBooks.Contains(book))
            {
                borrowedBooks.Remove(book);
                books.Add(book);
                Console.WriteLine("\nBook returned successfully.");
            }
            else
            {
                Console.WriteLine("This book was not borrowed.");
            }
        }
    }
}
