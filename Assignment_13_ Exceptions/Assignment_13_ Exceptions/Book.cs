using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_13__Exceptions
{
    public class Book
    {
        public int BookNumber { get; }
        public string Title { get; }
        public string Author { get; }

        public Book(int bookNumber, string title, string author)
        {
            if (bookNumber is <= 0)
                throw new ArgumentOutOfRangeException(nameof(bookNumber), "Book number must be a positive integer.");

            if (string.IsNullOrWhiteSpace(title))
                throw new ArgumentException("Title cannot be null or empty.", nameof(title));

            if (string.IsNullOrWhiteSpace(author))
                throw new ArgumentException("Author cannot be null or empty.", nameof(author));

            BookNumber = bookNumber;
            Title = title;
            Author = author;
        }
    }
}
