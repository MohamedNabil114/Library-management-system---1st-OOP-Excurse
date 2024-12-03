using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_management_system_project
{
    internal class LibraryUser : User
    {
        public LibraryCard Card { get; set; }

        public void Borrow(Book book, Library library)
        {
            library.Borrow(book);
        }

        public void Return(Book book, Library library)
        {
            library.ReturnBook(book);
        }
    }
}
