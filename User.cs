using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_management_system_project
{
    internal abstract class User
    {
        public string Name { get; set; }

        public void BrowseBooks(Library library)
        {
            if (library == null)
            {
                Console.WriteLine("Library is not available.");
                return;
            }

            library.Display();
        }
    }
}
