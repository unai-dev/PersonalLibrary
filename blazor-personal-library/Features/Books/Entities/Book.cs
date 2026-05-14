namespace blazor_personal_library.Features.Books.Entities
{
    public class Book
    {
        public int Id { get; set; }
        public string? Title { get; set; }
        public bool? State { get; set; } = false;
        public string? Author { get; set; }
        public string? BookImage { get; set; }

    }
}
