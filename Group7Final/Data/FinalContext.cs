using Microsoft.EntityFrameworkCore;
using Group7Final.Models;

namespace Group7Final.Data
{
    public class FinalContext : DbContext
    {
        public FinalContext(DbContextOptions<FinalContext> options) : base(options) { }
        public DbSet<Dessert> Desserts { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Add initial table data here:
            modelBuilder.Entity<Dessert>().HasData(
                new Dessert { TeamMember = "Isabelle", DessertName = "Brownie Cheesecake", DessertType = "Cheesecake", DessertTemp = "Cold" },
                new Dessert { TeamMember = "Lai", DessertName = "Dulce De Leche Cheesecake", DessertType = "Cheesecake", DessertTemp = "Cold" },
                new Dessert { TeamMember = "Eli", DessertName = "Maple Eclair", DessertType = "Donut", DessertTemp = "Hot" },
                new Dessert { TeamMember = "Danny", DessertName = "Mint Chocolate Chip Malt", DessertType = "Ice Cream", DessertTemp = "Cold" },
                new Dessert { TeamMember = "Jack", DessertName = "Rock", DessertType = "Rock", DessertTemp = "Hot" }
            );
        }
    }
}
