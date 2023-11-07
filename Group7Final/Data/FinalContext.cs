using Microsoft.EntityFrameworkCore;

namespace Group7Final.Data
{
    public class FinalContext : DbContext
    {
        public FinalContext(DbContextOptions options) : base(options) { }
    }
}
