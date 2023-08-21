using Models;
using System;
using Utils;

namespace libMan
{
    class Program
    {
        static void Main(string[] args)
        {
            Library library = new Library();

            while (true)
            {
                Console.WriteLine("Menyu");
                Console.WriteLine("1. Add Book");
                Console.WriteLine("2. Filter by Price");
                Console.WriteLine("3. Filter by Genre");
                Console.WriteLine("4. Find Book by No");
                Console.WriteLine("5. Remove All Books matching criteria");
                Console.WriteLine("6. Exit");
                Console.Write("Select an option: ");

                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Book book = new Book();
                        Console.WriteLine("Enter name of book:");
                        book.Name = Console.ReadLine();
                        Console.WriteLine("Enter authotname of book:");
                        book.AuthorName = Console.ReadLine();
                        Console.WriteLine("Enter price of book:");
                        book.Price = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Enter genre of book: (1-6,  Fiction = 1, NonFiction, Mystery, Horror, ScienceFinction, Fantasy)");
                        book.Genre = (Genre)Enum.Parse(typeof(Genre), Console.ReadLine());
                        library.AddBook(book);
                        break;
                    case 2:
                        Console.WriteLine("Enter minimum price:");
                        double minPrice = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Enter maximum price:");
                        double maxPrice = Convert.ToDouble(Console.ReadLine());

                        Library.PrintBooks(library.FilterByPrice(minPrice, maxPrice));
                        break;
                    case 3:
                        Console.WriteLine("Enter genre of book: (1-6,  Fiction = 1, NonFiction, Mystery, Horror, ScienceFinction, Fantasy)");
                        Genre genre = (Genre)Enum.Parse(typeof(Genre), Console.ReadLine());
                        Library.PrintBooks(library.FilterByGenre(genre));
                        break;
                    case 4:
                        Console.WriteLine("Enter number of book:");
                        int bookNo = Convert.ToInt32(Console.ReadLine());
                        Book foundBook = library.FilterBookByNo(bookNo);

                        if (foundBook != null)
                        {
                            Console.WriteLine("Book is here:");
                            Library.PrintBook(foundBook);
                        }
                        else
                        {
                            Console.WriteLine("Book was not found");
                        }
                        break;
                    case 5:
                        Console.WriteLine("Enter genre of book: (1-6,  Fiction = 1, NonFiction, Mystery, Horror, ScienceFinction, Fantasy)");
                        Genre genreRemove = (Genre)Enum.Parse(typeof(Genre), Console.ReadLine());
                        library.RemoveSpecified(book => book.Genre == genreRemove);
                        Console.WriteLine("Books with that genre were removed.");
                        break;
                    case 6:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Please write correct number from menu!");
                        break;
                }
            }
        }
    }
}
