using System;

namespace Library_management_system_project
{
    public class Program
    {
        static void Main(string[] args)
        {
            Library library1 = new Library("The Friends");
            Console.WriteLine($"Welcome to {library1.LibraryName} System");
            Console.WriteLine("\nAre you librarian or regular user?(L for Librarian, R for Library User):");

            char userType = Console.ReadLine().ToUpper()[0];

            if (userType == 'L')
            {
                Console.WriteLine("Welcome Librarian, Enter your name:");
                string librarianName = Console.ReadLine();
                Librarian librarian = new Librarian(librarianName);
                Console.WriteLine($"Welcome {librarian.Name}");

                while (true)
                {
                    Console.WriteLine("\nChoose from this menu: \n-A TO Add Book \n-D TO Delete Book \n-B TO Browse Books ");
                    char librarianInput = Console.ReadLine().ToUpper()[0];
                    switch (librarianInput)
                    {
                        case 'A':
                            Console.WriteLine("Enter Book Details: ");
                            Console.Write("Book Name: ");
                            string bookName = Console.ReadLine();
                            Console.Write("Book Author: ");
                            string bookAuthor = Console.ReadLine();
                            Console.Write("Book Year: ");
                            int bookYear = int.Parse(Console.ReadLine());
                            Book book = new Book()
                            {
                                Title = bookName,
                                Author = bookAuthor,
                                Year = bookYear
                            };
                            librarian.AddBook(book, library1);
                            break;
                        case 'D':
                            Console.WriteLine("Enter the details of the book you want to delete:");
                            Console.Write("Book Name: ");
                            bookName = Console.ReadLine();
                            Console.Write("Book Author: ");
                            bookAuthor = Console.ReadLine();
                            Console.Write("Book Year: ");
                            bookYear = int.Parse(Console.ReadLine());
                            book = new Book()
                            {
                                Title = bookName,
                                Author = bookAuthor,
                                Year = bookYear
                            };
                            librarian.DeleteBook(book, library1);
                            break;
                        case 'B':
                            librarian.BrowseBooks(library1);
                            break;
                        default:
                            Console.WriteLine("Invalid Input. Please enter 'A' or 'D' or 'B'.");
                            break;
                    }
                }
            }
            else if (userType == 'R')
            {
                Console.WriteLine("Welcome User, Enter your name: ");
                string userName = Console.ReadLine();
                LibraryUser libraryUser = new LibraryUser();
                Console.WriteLine($"Welcome {libraryUser.Name}");

                while (true)
                {
                    Console.WriteLine("\nChoose from this menu:\n-D TO Display Books \n-B TO Borrow Book \n-R TO Return Book ");
                    char userInput = Console.ReadLine().ToUpper()[0];
                    switch (userInput)
                    {
                        case 'D':
                            libraryUser.BrowseBooks(library1);
                            break;
                        case 'B':
                            Console.WriteLine("Enter Book Details: ");
                            Console.Write("Book Name: ");
                            string bookNameToBorrow = Console.ReadLine();
                            Console.Write("Book Author: ");
                            string bookAuthorToBorrow = Console.ReadLine();
                            Console.Write("Book Year: ");
                            int bookYearToBorrow = int.Parse(Console.ReadLine());
                            Book book = new Book()
                            {
                                Title = bookNameToBorrow,
                                Author = bookAuthorToBorrow,
                                Year = bookYearToBorrow
                            };
                            libraryUser.Borrow(book, library1);
                            break;
                        case 'R':
                            Console.WriteLine("Enter Book Details: ");
                            Console.Write("Book Name: ");
                            bookNameToBorrow = Console.ReadLine();
                            Console.Write("Book Author: ");
                            bookAuthorToBorrow = Console.ReadLine();
                            Console.Write("Book Year: ");
                            bookYearToBorrow = int.Parse(Console.ReadLine());
                            book = new Book()
                            {
                                Title = bookNameToBorrow,
                                Author = bookAuthorToBorrow,
                                Year = bookYearToBorrow
                            };
                            libraryUser.Return(book, library1);
                            break;
                        default:
                            Console.WriteLine("Invalid Input. Please enter 'B' or 'D'.");
                            break;
                    }
                }
            }
            else
            {
                Console.WriteLine("Invalid user type. Please enter 'L' or 'R'.");
                Environment.Exit(0);
            }
        }
    }
}
