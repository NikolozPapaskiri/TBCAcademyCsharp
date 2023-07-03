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
            if (string.IsNullOrWhiteSpace(title))
                throw new ArgumentNullException(nameof(title), "Title cannot be null or empty.");

            if (string.IsNullOrWhiteSpace(author))
                throw new ArgumentNullException(nameof(author), "Author cannot be null or empty.");

            BookNumber = bookNumber;
            Title = title;
            Author = author;
        }
    }
}
