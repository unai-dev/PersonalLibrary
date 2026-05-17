using blazor_personal_library.Features.Categories.Entities;
using blazor_personal_library.Features.Categories.Interfaces;

namespace blazor_personal_library.Features.Categories.Services
{
    public class CategoryService : ICategoryService
    {
        public List<Category> _categories;

        public CategoryService()
        {
            _categories = new List<Category>()
            {
                new Category
                {
                    Id = 1,
                    Name = "Programacion"
                },
                new Category
                {
                    Id = 2,
                    Name = "Contabilidad"
                },
                new Category
                {
                    Id = 3,
                    Name = "Vida"
                },
            };
        }

        public List<Category> GetCategories()
        {
            return _categories;
        }

        public void AddCategory(Category category)
        {
            _categories.Add(category);
        }
    }
}
