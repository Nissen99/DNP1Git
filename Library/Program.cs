using System;
using System.Linq;
using Library.Models;
using Library.Persistence;
using Microsoft.EntityFrameworkCore;

namespace Library
{
    class Program
    {
        static void Main(string[] args)
        {
           // AddBookGenreAuthor();
            //AddAuthor();
            //AddBookToAuthor();
            GetBook();
        }

        
        private static void GetBook()
        {
            using (LibraryContext lb = new LibraryContext())
            {
                Book first = lb.Books
                    .Include(book => book.Author)
                    .Include(book => book.Genre).First(book => book.ISBN == 765326353);
                Console.WriteLine(first);
            }
        }
        private static void AddBookToAuthor()
        {
            using (LibraryContext libraryContext = new LibraryContext())
            {
                Author a = libraryContext.Authors.First(a => a.FirstName.Equals("Stephen") && a.LastName.Equals("King"));
                Book b = new Book
                {
                    Author = a,
                    Title = "The Shining",
                    ISBN = 0450040186,
                    PublishDate = new DateTime(1980, 1, 28),
                    TotalPages = 659
                };
                libraryContext.Books.Add(b);
                libraryContext.SaveChanges();
            }
        }

        private static void AddAuthor()
        {
            Author author = new Author
            {
                FirstName = "Stephen",
                LastName = "King",
                Bio = "I am pretty famous"
            };
            using (LibraryContext libraryContext = new LibraryContext())
            {
                libraryContext.Authors.Add(author);
                libraryContext.SaveChanges();
            }
        }
        private static void AddBookGenreAuthor()
        {
            Genre highFantasyGenre = new Genre
            {
                GenreName = "High Fantasy"
            };
            Author brandonAuthor = new Author
            {
                FirstName = "Brandon",
                LastName = "Sanderson",
                Bio = "I write good stuff"
            };
            Book theWayOfKingsBook = new Book
            {
                Author = brandonAuthor,
                Genre = highFantasyGenre,
                Title = "The Way of Kings",
                ISBN = 0765326353,
                PublishDate = new DateTime(2010, 7, 31),
                TotalPages = 1007
            };
            using (LibraryContext libraryContext = new LibraryContext())
            {
                libraryContext.Books.Add(theWayOfKingsBook);
                libraryContext.SaveChanges();
            } 
        }
    }
}