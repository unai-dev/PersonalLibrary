using blazor_personal_library.Features.BookAuthors.Entities;
using blazor_personal_library.Features.BookCategories.Entities;
using blazor_personal_library.Features.Categories.Entities;
using blazor_personal_library.Shared.Validations;
using Microsoft.AspNetCore.Components.Forms;
using System.ComponentModel.DataAnnotations;

namespace blazor_personal_library.Features.Books.Entities
{
    public class Book
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "The field {0} is required")]
        [FirstUpperAttribute]
        public string Title { get; set; } = string.Empty;
        public bool State { get; set; } = false;
        public string? BookImage { get; set; }
        public IBrowserFile? FilePicture { get; set; }

        // Relaciones
        public List<BookCategory> BookGenders { get; set; } = new List<BookCategory>();
        public List<BookAuthor> BookAuthors { get; set; } = new List<BookAuthor>();

    }
}
