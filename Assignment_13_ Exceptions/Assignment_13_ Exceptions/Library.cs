using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_13__Exceptions
{
    public class Library
    {
        private List<Book> books;

        public int Capacity { get; }

        public Library(int capacity)
        {
            if (capacity <= 0)
                throw new ArgumentOutOfRangeException(nameof(capacity), "Capacity must be a positive integer.");

            Capacity = capacity;
            books = new List<Book>();
        }

        public void AddBook(Book book)
        {
            if (book == null)
                throw new ArgumentNullException(nameof(book), "Book cannot be null.");

            if (books.Count >= Capacity)
                throw new IndexOutOfRangeException("Library capacity reached. Cannot add more books.");

            books.Add(book);
        }

        public Book GetBook(int bookNumber)
        {
            foreach (var book in books)
            {
                if (book.BookNumber == bookNumber)
                    return book;
            }

            throw new BookNotFoundException($"Book with number '{bookNumber}' not found in the library.");
        }

        public void ShowList()
        {
            Console.WriteLine("Books in the Library:");
            foreach (var book in books)
            {
                Console.WriteLine($"Book Number: {book.BookNumber}, Title: {book.Title}, Author: {book.Author}");
            }
        }
    }
}
