using Microsoft.EntityFrameworkCore;
using Group7Final.Models;

namespace Group7Final.Data
{
    public class FinalContext : DbContext
    {
        public FinalContext(DbContextOptions<FinalContext> options) : base(options) { }
        public DbSet<Dessert> Desserts { get; set; }
        public DbSet<Movie> Movies { get; set; }

        public DbSet<Team> Teams { get; set; }
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
            modelBuilder.Entity<Team>().HasData(
                new Team { Id = 1, TeamMember = "Isabelle Kramer", Birthdate = 11 / 04 / 2003, ProgramName = "IT", YearName = "Pre Junior" },
                new Team { Id = 2, TeamMember = "Lai Connelly", Birthdate = 10 / 15 / 2003, ProgramName = "IT", YearName = "Sophomore" },
                new Team { Id = 3, TeamMember = "Eli Douglass", Birthdate = 12 / 26/ 2002, ProgramName = "IT", YearName = "Pre Junior" },
                new Team { Id = 4, TeamMember = "Danny Murray", Birthdate = 03 / 04 / 2004, ProgramName = "IT", YearName = "Sophomore" },
                new Team { Id = 5, TeamMember = "Jacob Junker", Birthdate = 03 / 24 / 2004, ProgramName = "IT", YearName = "Sophomore" }
            );
        }
    }
}
