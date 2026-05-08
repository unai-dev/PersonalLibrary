namespace blazor_personal_library.Features.Books.Entities
{
    public class Book
    {
        public int Id { get; set; }
        public required string Title { get; set; }
        public bool State { get; set; } = false;
        public required string Author { get; set; }

    }
}
