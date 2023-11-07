using Microsoft.EntityFrameworkCore;
using Group7Final.Models;

namespace Group7Final.Data
{
    public class FinalContext : DbContext
    {
        public FinalContext(DbContextOptions<FinalContext> options) : base(options) { }
        public DbSet<Dessert> Desserts { get; set; }
    }
}
