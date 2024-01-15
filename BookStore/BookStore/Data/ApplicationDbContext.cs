using BookStore.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace BookStore.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<ApplicationUser> ApplicationUser { get; set; }
        public DbSet<Book> books { get; set; }

        public DbSet<OrderBook> OrderBooks { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Your model configurations...

            base.OnModelCreating(modelBuilder);
        }

    }
}
