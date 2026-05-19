using blazor_personal_library.Features.Authors.Entities;
using blazor_personal_library.Features.Books.Entities;

namespace blazor_personal_library.Features.BookAuthors.Entities
{
    public class BookAuthor
    {
        public Book? Book { get; set; }
        public int BookId { get; set; }

        public Author? Author { get; set; }
        public int AuthorId { get; set; }
    }
}
