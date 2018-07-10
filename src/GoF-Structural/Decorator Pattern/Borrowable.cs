using System;
using System.Collections.Generic;

namespace Decorator_Pattern
{
    /// <summary>
    /// Concrete Decorator
    /// </summary>
    class Borrowable : IDecorator
    {
        protected List<string> borrowers = new List<string>();

        public ILibraryItem libraryItem { get; set; }

        // Constructor

        public Borrowable(ILibraryItem libraryItem)
        {
            this.libraryItem = libraryItem;
        }

        public void BorrowItem(string name)
        {
            borrowers.Add(name);
            libraryItem.NumCopies--;
        }

        public void ReturnItem(string name)
        {
            borrowers.Remove(name);
            libraryItem.NumCopies++;
        }

        public void Display()
        {
            this.libraryItem.Display();
            foreach (string borrower in borrowers)
            {
                Console.WriteLine($" borrower: {borrower}");
            }
        }
    }
}
