using System;

namespace Decorator_Pattern
{
    class Book : ILibraryItem
    {
        public int NumCopies { get; set; }

        private readonly string _author;
        private readonly string _title;

        public Book(string author, string title, int numOfCopies)
        {
            this._author = author;
            this._title = title;
            this.NumCopies = numOfCopies;
        }

        public void Display()
        {
            Console.WriteLine("\nBook ------ ");
            Console.WriteLine(" Author: {0}", _author);
            Console.WriteLine(" Title: {0}", _title);
            Console.WriteLine(" # Copies: {0}", NumCopies);
        }
    }
}
