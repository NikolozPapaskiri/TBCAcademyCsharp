using System;
using System.Collections.Generic;

namespace Assignment_13__Exceptions
{
    public class Program
    {
        public static void Main()
        {
            try
            {
                Console.WriteLine("Enter the library capacity:");
                int capacity = ReadInput.ReadPositiveInteger();

                Library library = new Library(capacity);

                Console.WriteLine("Enter the number of books to add:");
                int numBooks = ReadInput.ReadPositiveInteger();

                while (numBooks > capacity)
                {
                    Console.WriteLine($"Maximum avalilable number of books are {capacity}. \nEnter the number of books to add:");
                    numBooks = ReadInput.ReadPositiveInteger();
                }

                for (int i = 0; i < numBooks; i++)
                {
                    Console.WriteLine($"Enter details for Book {i + 1}:");
                    Console.Write("Book Number: ");
                    int bookNumber = ReadInput.ReadPositiveInteger();
                    Console.Write("Title: ");
                    string title = Console.ReadLine();
                    Console.Write("Author: ");
                    string author = Console.ReadLine();

                    Book book = new Book(bookNumber, title, author);
                    library.AddBook(book);

                    Console.WriteLine("Book added to the library.");
                    Console.WriteLine();
                }

                Console.WriteLine("Library Capacity: " + library.Capacity);
                Console.WriteLine();

                library.ShowList();
                Console.WriteLine();

                Console.WriteLine("Enter the book number to search:");
                int bookNumberToSearch = ReadInput.ReadPositiveInteger();

                try
                {
                    Book book = library.GetBook(bookNumberToSearch);
                    Console.WriteLine($"Book Found - Title: {book.Title}, Author: {book.Author}");
                }
                catch (BookNotFoundException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
            }
        }
    }

    
}
