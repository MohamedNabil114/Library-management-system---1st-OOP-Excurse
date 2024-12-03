using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Library_management_system_project
{
    internal class Librarian : User
    {
        public Librarian(string name) { Name = name;}
        public int Employee_Number { get; set; }

        public void AddBook(Book book, Library library)
        {
            
            library.Add(book);
        }
        public void DeleteBook(Book book ,Library library)
        {
            library.Delete(book);
        }
    }
}
