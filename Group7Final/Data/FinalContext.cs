using Microsoft.EntityFrameworkCore;
using Group7Final.Models;

namespace Group7Final.Data
{
    public class FinalContext : DbContext
    {
        public FinalContext(DbContextOptions<FinalContext> options) : base(options) { }
        public DbSet<Dessert> Desserts { get; set; }
        public DbSet<Movie> Movies { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Add initial table data here:
            modelBuilder.Entity<Dessert>().HasData(
                new Dessert { Id = 1, TeamMember = "Isabelle", DessertName = "Brownie Cheesecake", DessertType = "Cheesecake", DessertTemp = "Cold" },
                new Dessert { Id = 2, TeamMember = "Lai", DessertName = "Dulce De Leche Cheesecake", DessertType = "Cheesecake", DessertTemp = "Cold" },
                new Dessert { Id = 3, TeamMember = "Eli", DessertName = "Maple Eclair", DessertType = "Donut", DessertTemp = "Hot" },
                new Dessert { Id = 4, TeamMember = "Danny", DessertName = "Mint Chocolate Chip Malt", DessertType = "Ice Cream", DessertTemp = "Cold" },
                new Dessert { Id = 5, TeamMember = "Jack", DessertName = "Cookies n Cream Ice Cream", DessertType = "Ice Cream", DessertTemp = "Cold" }
            );
            modelBuilder.Entity<Movie>().HasData(
                new Movie { Id = 1, TeamMember = "Eli", MovieName = "Perfect Blue", Director = "Satoshi Kon", ReleaseYear = 1197 },
                new Movie { Id = 2, TeamMember = "Lai", MovieName = "Phantom of the Opera", Director = "Joel Schomacher", ReleaseYear = 2004 },
                new Movie { Id = 3, TeamMember = "Isabelle", MovieName = "Legally Blande", Director = "Robert Luketic", ReleaseYear = 2001 },
                new Movie { Id = 4, TeamMember = "Danny", MovieName = "Puss In Boots: The Last Wish", Director = "Joel Crawford", ReleaseYear = 2022 },
                new Movie { Id = 5, TeamMember = "Jacob", MovieName = "Avengers: Endgame", Director = "The Russo Brothers", ReleaseYear = 2019 }
                );
        }
    }
}
