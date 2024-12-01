using Microsoft.EntityFrameworkCore;

namespace FoodRegistryApp1.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Food> Foods { get; set; }  // Denne representerer tabellen i databasen
    }
}
