using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utils;

namespace Models
{
    public class Library
    {
        public List<Book> Books = new List<Book>();

        public void AddBook(Book book)
        {
            Books.Add(book);
        }

        public List<Book> FilterByPrice(double minPrice, double maxPrice)
        {
            return Books.FindAll(book => book.Price >= minPrice && book.Price <= maxPrice);
        }

        public List<Book> FilterByGenre(Genre genre)
        {
            return Books.FindAll(book => book.Genre == genre);
        }

        public Book FilterBookByNo(int bookNo)
        {
            return Books.Find(book => book.No == bookNo);
        }

        public void RemoveSpecified(Predicate<Book> predicate)
        {
            Books.RemoveAll(predicate);
        }

        public static void PrintBook(Book book)
        {
            Console.WriteLine($"No: {book.No}");
            Console.WriteLine($"Name: {book.Name}");
            Console.WriteLine($"Author: {book.AuthorName}");
            Console.WriteLine($"Genre: {book.Genre}");
            Console.WriteLine($"Price: {book.Price}");
            Console.WriteLine();
        }

        public static void PrintBooks(List<Book> books)
        {
            if (books.Count > 0)
            {
                Console.WriteLine("Books:");
                foreach (Book book in books)
                {
                    PrintBook(book);
                }
            }
            else
            {
                Console.WriteLine("There is no book that satisfies this criteria.");
            }
        }
    }
}
