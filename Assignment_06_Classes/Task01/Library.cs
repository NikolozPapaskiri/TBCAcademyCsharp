using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarySystem
{
    public class Library
    {
        private Book[] _books;

        public Library(int capacity)
        {
            _books = new Book[capacity];
        }

        public Book this[int index]
        {
            get { return _books[index]; }
            set { _books[index] = value; }
        }

        public int Count
        {
            get { return _books.Length; }
        }

        public void AddBook(Book book)
        {
            bool isLibraryFull = Array.TrueForAll(_books, b => b != null);
            if (isLibraryFull)
            {
                Console.WriteLine("Library is full. Cannot add more books.");
                return;
            }

            int index = Array.FindIndex(_books, b => b == null);
            _books[index] = book;
            Console.WriteLine("Book added successfully.");
        }

        public void RemoveBook(Book book)
        {
            int index = Array.IndexOf(_books, book);
            if (index == -1)
            {
                Console.WriteLine("Book not found in the library.");
                return;
            }

            _books[index] = null;
            Console.WriteLine("Book removed successfully.");
        }

        public Book FindBook(string title)
        {
            return Array.Find(_books, b => b?.Title == title);
        }
    }
}
