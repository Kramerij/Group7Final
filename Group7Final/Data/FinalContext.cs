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
            // Add initial table data here:
            modelBuilder.Entity<Dessert>().HasData(
                new Dessert { TeamMember = "Isabelle", DessertName = "Brownie Cheesecake", DessertType = "Cheesecake", DessertTemp = "Cold" },
                new Dessert { TeamMember = "Lai", DessertName = "Dulce De Leche Cheesecake", DessertType = "Cheesecake", DessertTemp = "Cold" },
                new Dessert { TeamMember = "Eli", DessertName = "Maple Eclair", DessertType = "Donut", DessertTemp = "Hot" },
                new Dessert { TeamMember = "Danny", DessertName = "Mint Chocolate Chip Malt", DessertType = "Ice Cream", DessertTemp = "Cold" },
                new Dessert { TeamMember = "Jack", DessertName = "Rock", DessertType = "Rock", DessertTemp = "Hot" }
            );
            modelBuilder.Entity<Movie>().HasData(
                new Movie {TeamMember = "Eli", MovieName = "Perfect Blue", Director = "Satoshi Kon", ReleaseYear = 1197 },
                new Movie { TeamMember = "Lai", MovieName = "Phantom of the Opera", Director = "Joel Schomacher", ReleaseYear = 2004  },
                new Movie { TeamMember = "Isabelle", MovieName = "Legally Blande", Director = "Robert Luketic", ReleaseYear = 2001 },
                new Movie { TeamMember = "Danny", MovieName = "Puss In Boots: The Last Wish", Director = "Joel Crawford", ReleaseYear = 2022 },
                new Movie { TeamMember = "Jacob", MovieName = "Avengers: Endgame", Director = "The Russo Brothers", ReleaseYear = 2019 }
                );
        }
    }
}
