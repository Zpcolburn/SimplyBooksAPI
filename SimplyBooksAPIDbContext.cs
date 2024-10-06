using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Hosting;
using SimplyBooksAPI.Data;
using SimplyBooksAPI.Models;
namespace SimplyBooksAPI
{
    public class SimplyBooksAPIDbContext : DbContext
    {
        public DbSet<Author> Authors { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<User> Users { get; set; }

        public SimplyBooksAPIDbContext(DbContextOptions<SimplyBooksAPIDbContext> context) : base(context)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Send data to Authors table
            modelBuilder.Entity<Author>().HasData(AuthorData.Authors);

            // Send data to Books table
            modelBuilder.Entity<Book>().HasData(BookData.Books);

            // Send data to Users table
            modelBuilder.Entity<User>().HasData(UserData.Users);

            modelBuilder.Entity<Book>()
                .HasOne(b => b.Author)
                .WithMany(a => a.Books)
                .HasForeignKey(b => b.AuthorId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
