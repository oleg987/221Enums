using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _221Enums
{
    public class Library
    {
        private Book[] _books;

        public Library(Book[] books)
        {
            _books = books;
        }

        public Library()
        {
            _books = new Book[0];
        }

        public void AddBook(Book book)
        {
            Array.Resize(ref _books, _books.Length + 1);

            _books[_books.Length - 1] = book;
        }

        public void AddBook(Book[] books)
        {
            //foreach (var book in books)
            //{
            //    AddBook(book);
            //}

            Array.Resize(ref _books, _books.Length + books.Length);

            books.CopyTo(_books, _books.Length - books.Length - 1);
        }

        public string GetAllBookTitles()
        {
            //string titles = "";

            //foreach (var book in _books)
            //{
            //    titles += book.Title + "\r\n";
            //}

            StringBuilder builder = new StringBuilder();

            foreach (var book in _books)
            {
                builder.AppendLine(book.Title);
            }

            return builder.ToString();
        }

        public Book[] SearchByTitle(string title)
        {
            Book[] search = new Book[0];

            foreach (var book in _books)
            {                
                if (book.Title.ToUpper().Contains(title.ToUpper()))
                {
                    Array.Resize(ref search, search.Length + 1);
                    search[search.Length - 1] = book;
                }
            }

            return search;
        }
    }
}
