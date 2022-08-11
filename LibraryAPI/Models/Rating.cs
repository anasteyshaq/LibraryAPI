using System.ComponentModel.DataAnnotations.Schema;

namespace LibraryAPI.Models
{
    public class Rating
    {
        #pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        public int RatingId { get; set; }
        public decimal Score { get; set; }
        public int BookId { get; set; }

        [ForeignKey("BookId")]
        public Book Book { get; set; } 
    }
}
