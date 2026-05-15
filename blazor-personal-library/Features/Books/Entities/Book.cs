using blazor_personal_library.Shared.Validations;
using System.ComponentModel.DataAnnotations;

namespace blazor_personal_library.Features.Books.Entities
{
    public class Book
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "The field {0} is required")]
        [FirstUpperAttribute]
        public string? Title { get; set; }
        public bool State { get; set; } = false;

        [Required(ErrorMessage = "The field {0} is required")]
        [FirstUpperAttribute]
        public string? Author { get; set; }
        public string? BookImage { get; set; }
        public bool Favorite { get; set; } = false;

    }
}
