using System;
using System.Collections.Generic;
using static System.Reflection.Metadata.BlobBuilder;

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

                    int bookNumber;
                    do
                    {
                        Console.Write("Book Number: ");
                        string bookNumberInput = Console.ReadLine();
                        if (!int.TryParse(bookNumberInput, out bookNumber) || bookNumber <= 0)
                        {
                            Console.WriteLine("Invalid input. Book Number must be a positive integer.");
                        }
                    } while (bookNumber <= 0);

                    string title;
                    do
                    {
                        Console.Write("Title: ");
                        title = Console.ReadLine();
                        if (string.IsNullOrWhiteSpace(title))
                        {
                            Console.WriteLine("Invalid input. Title cannot be null or empty.");
                        }
                    } while (string.IsNullOrWhiteSpace(title));

                    string author;
                    do
                    {
                        Console.Write("Author: ");
                        author = Console.ReadLine();
                        if (string.IsNullOrWhiteSpace(author))
                        {
                            Console.WriteLine("Invalid input. Author cannot be null or empty.");
                        }
                    } while (string.IsNullOrWhiteSpace(author));

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
