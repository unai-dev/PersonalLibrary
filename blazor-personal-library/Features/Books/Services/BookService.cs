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
                Author = "Robert C. Martin",
                State = true,
                BookImage = "https://m.media-amazon.com/images/I/41nUxzDHD-L._SY445_SX342_ML2_.jpg"
            },

                new Book
            {
                Id = 2,
                Title = "The Pragmatic Programmer",
                Author = "Andrew Hunt & David Thomas",
                State = false,
                BookImage = "https://cdn.waterstones.com/bookjackets/large/9780/1359/9780135957059.jpg"
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
