using DeepDiveIntoEnglishLanding.Models;
using Microsoft.EntityFrameworkCore;

namespace DeepDiveIntoEnglishLanding.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
            
        }
        public DbSet<Review> Reviews { get; set; }
        public DbSet<Image> Images { get; set; }
    }
}