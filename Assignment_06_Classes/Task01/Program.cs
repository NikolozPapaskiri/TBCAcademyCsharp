namespace LibrarySystem
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Library library = new Library(4);

            // წიგნების დამატება ბიბლიოთეკაში
            library.AddBook(new Book { Title = "Book 1", Author = "Author 1", Year = 2021 });
            library.AddBook(new Book { Title = "Book 2", Author = "Author 2", Year = 2022 });
            library.AddBook(new Book { Title = "Book 3", Author = "Author 3", Year = 2023 });
            library.AddBook(new Book { Title = "Book 4", Author = "Author 4", Year = 2023 });
            library.AddBook(new Book { Title = "Book 5", Author = "Author 5", Year = 2023 });//არუნდა დაამატოს უკვე სავსეა Library

            // მივწვდეთ წიგნებს ინდექსებით
            Console.WriteLine("Book at index 1: " + library[1].Title);

            // წიგნის წაშლა ბიბლიოთეკიდან
            library.RemoveBook(library[1]);

            // წიგნის პოვნა
            Book notFoundBook = library.FindBook("Book 55");//ისეთი წიგნი რომელიც არ გვაქ ბიბლიოთეკაში
            if(notFoundBook != null)
                Console.WriteLine("Found book: " + notFoundBook?.Title);

            Book foundBook = library.FindBook("Book 3");//ისეთი წიგნი რომელიც გვაქ ბიბლიოთეკაში
            if (foundBook != null)
                Console.WriteLine("Found book: " + foundBook?.Title);

            Console.WriteLine("Number of books in the library: " + library.Count);

        }
    }

}


/*
 1)შექმენით namespace LibrarySystem
2)ამ namespace ში დაამატეთ კლასი Book, რომელსაც ექნება property ები:
        Title
        Author
        Year 
        (სურვილისამებრ დაამატეთ სხვა ველებიც)
3)შექმენით კლასი Library. Library კლასში უნდა გვქონდეს პრივატული ველი რომელიც იქნება Book ობიექტების მასივი
3.1)Library კლასს უნდა ჰქონდეს ინდექსერი, რომელიც როგორც დააბრუნებს წიგნს ზემოთ ხსენებული ველიდან, ასევე დასეტავს კიდეც
3.2)უნდა გვქონდეს Count property რომელიც დაგვიბრუნებს წიგნების რაოდენობას ბიბლიოთეკაში
3.3)უნდა გვქონდეს AddBook მეთოდი, რომელიც დაამატებს ბიბლიოთეკაში წიგნებს
3.4)RemoveBook მეთოდი რომელიც წაშლის ბიბლიოთეკიდან წიგნებს
3.5)FindBook მეთოდი რომელიც მოძებნის ბიბლიოთეკაში წიგნებს
4)თქვენი შექმნილი კლასები დააინიციალიზირეთ და გატესტეთ ბიბლიოთეკის ფუნქციონალი.
*/