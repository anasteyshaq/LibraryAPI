namespace LibraryAPI.ViewModels
{
    public class BookViewModel
    {
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        public int BookId { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public decimal Rating { get; set; } = 0; // average rating
        public int ReviewsNumber { get; set; } = 0; // count of reviews


    }
}
