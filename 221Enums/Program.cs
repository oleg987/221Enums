using System;

namespace _221Enums
{
    public class Program
    {
        static void Main(string[] args)
        {
            Author author = new Author("Jack", "London");

            Book book = new Book("White Fang", author);

            Library library = new Library();

            library.AddBook(book);

            Console.WriteLine("All books:");
            Console.WriteLine(library.GetAllBookTitles());

            Book[] search = library.SearchByTitle("WhItE");
            Console.WriteLine("Search:");
            foreach (Book bookSearch in search)
            {
                Console.WriteLine(bookSearch.Info());
            }
        }
    }
}
