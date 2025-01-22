using System;
using LibraryManagementSystem.Models;
using LibraryManagementSystem.Utilities;

namespace LibraryManagementSystem.Services
{
    public class LibraryManager
    {
        private static LibraryManager instance;
        private Library library = new Library();

        // Private constructor for singleton
        private LibraryManager() { }

        // Get Singleton Instance
        public static LibraryManager GetInstance()
        {
            if (instance == null)
            {
                instance = new LibraryManager();
            }
            return instance;
        }

        // Start the library system menu
        public void Run()
        {
            Menu.DisplayMenu(library);
        }
    }
}
