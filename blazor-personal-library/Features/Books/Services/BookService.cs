using blazor_personal_library.Features.Books.Entities;
using blazor_personal_library.Features.Books.Interfaces;

namespace blazor_personal_library.Features.Books.Services
{
    public class BookService : IBookService
    {
        private readonly List<Book> _books;

        public BookService()
        {
            _books = new List<Book>()
    {
        new Book
        {
            Id = 1,
            Title = "Clean Code",
            State = true,
            BookImage = "https://m.media-amazon.com/images/I/41nUxzDHD-L._SY445_SX342_ML2_.jpg"
        },
        new Book
        {
            Id = 2,
            Title = "The Pragmatic Programmer",
            State = false,
            BookImage = "https://cdn.waterstones.com/bookjackets/large/9780/1359/9780135957059.jpg"
        },
        new Book
        {
            Id = 3,
            Title = "Design Patterns",
            State = true,
            BookImage = "https://m.media-amazon.com/images/I/81IGFC6oFmL.jpg"
        },
        new Book
        {
            Id = 4,
            Title = "Refactoring",
            State = true,
            BookImage = "https://m.media-amazon.com/images/I/71vEr0oyt-L._AC_UF1000,1000_QL80_.jpg"
        },
        new Book
        {
            Id = 5,
            Title = "Domain-Driven Design",
            State = false,
            BookImage = "https://m.media-amazon.com/images/I/41uPjEenkFL._SY445_SX342_.jpg"
        },
        new Book
        {
            Id = 6,
            Title = "Clean Architecture",
            State = true,
            BookImage = "https://m.media-amazon.com/images/I/41-sN-mzwKL._SY445_SX342_.jpg"
        },
        new Book
        {
            Id = 7,
            Title = "Working Effectively with Legacy Code",
            State = false,
            BookImage = "https://m.media-amazon.com/images/I/81iVQ1bi-FL.jpg"
        },
        new Book
        {
            Id = 8,
            Title = "The Clean Coder",
            State = true,
            BookImage = "https://m.media-amazon.com/images/I/41jEbK-jG+L._SY445_SX342_.jpg"
        },
        new Book
        {
            Id = 9,
            Title = "You Don't Know JS (Series)",
            State = true,
            BookImage = "https://m.media-amazon.com/images/I/41xShlnTZTL._SY445_SX342_.jpg"
        },
        new Book
        {
            Id = 10,
            Title = "Introduction to Algorithms",
            State = false,
            BookImage = "https://m.media-amazon.com/images/I/61O5SsbL8HL._AC_UF1000,1000_QL80_.jpg"
        },
        new Book
        {
            Id = 11,
            Title = "The Mythical Man-Month",
            State = true,
            BookImage = "https://m.media-amazon.com/images/I/817iWsLJR0L.jpg"
        },
        new Book
        {
            Id = 12,
            Title = "Soft Skills: The Software Developer's Life Manual",
            State = true,
            BookImage = "https://m.media-amazon.com/images/I/41+XuvmjYOL._SY445_SX342_ML2_.jpg"
        }
    };
        }


        public List<Book> GetBooks()
        {
            return _books;
        }

        public void AddNewBook(Book book)
        {
            _books.Add(book);
        }
    }
}
