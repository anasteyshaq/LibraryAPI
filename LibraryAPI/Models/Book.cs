namespace LibraryAPI.Models
{
    public class Book
    {
        #pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        public int BookId { get; set; }
        public string Title { get; set; }
        public string? Cover { get; set; }
        public string? Content { get; set; }
        public string Author { get; set; }
        public string? Genre  { get; set; }
        public List<Review>? Reviews { get; set; } = new List<Review>();
        public List<Rating>? Ratings { get; set; } = new List<Rating>();
    }
}
