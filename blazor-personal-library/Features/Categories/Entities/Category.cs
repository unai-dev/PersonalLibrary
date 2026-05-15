using blazor_personal_library.Shared.Validations;
using System.ComponentModel.DataAnnotations;

namespace blazor_personal_library.Features.Categories.Entities
{
    public class Category
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "The field {0} is required")]
        [FirstUpperAttribute]
        public string? Name { get; set; }
    }
}
