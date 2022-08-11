using LibraryAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace LibraryAPI
{
    public class BookContext : DbContext
    {
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        public BookContext(DbContextOptions<BookContext> options)
            : base(options) { }
        public DbSet<Book> Books { get; set; }
        public DbSet<Review> Reviews { get; set; }
        public DbSet<Rating> Ratings { get; set; }
    }
}
