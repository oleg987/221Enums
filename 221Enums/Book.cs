using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _221Enums
{
    public class Book
    {
        private Author[] _authors;

        public string Title { get; set; }
        public int Year { get; set; }
        public string Genre { get; set; }
        public Author[] Authors { get => _authors; set => _authors = value; }

        public Book(string title, int year, string genre, Author[] authors)
        {
            // Check arguments
            Title = title;
            Year = year;
            Genre = genre;
            Authors = authors;
        }

        public Book(string title, Author[] authors)
        {
            // Check arguments
            Title = title;
            Authors = authors;
        }

        public Book(string title, Author author)
        {
            // Check arguments
            Title = title;
            Authors = new Author[1];
            Authors[0] = author;
        }

        public string Info()
        {
            string info = "";

            info += $"Title: {Title}\r\n";

            if(Year != 0)
            {
                info += $"Year: {Year}\r\n";
            }

            if (!string.IsNullOrWhiteSpace(Genre))
            {
                info += $"Genre: {Genre}\r\n";
            }

            info += "Authors: ";

            foreach (var author in Authors)
            {
                info += $"{author.LastName} {author.FirstName}, ";
            }

            return info;
        }

        public void AddAuthor(Author author)
        {
            Array.Resize(ref _authors, _authors.Length + 1);

            _authors[_authors.Length - 1] = author;
        }
    }
}
