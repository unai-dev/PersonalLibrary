using blazor_personal_library.Features.Books.Entities;
using blazor_personal_library.Features.Categories.Entities;

namespace blazor_personal_library.Features.BookCategories.Entities
{
    public class BookCategory
    {
        public Book? Book { get; set; }
        public int BookId { get; set; }

        public Category? Category { get; set; }
        public int CategoryId { get; set; }
    }
}
