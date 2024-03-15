using Microsoft.EntityFrameworkCore;

namespace Mission10_API.Data
{
    public class BowlingLeagueContext : DbContext
    {
        public BowlingLeagueContext(DbContextOptions<BowlingLeagueContext> options) : base(options) { }

        public DbSet<Bowlers> Bowlers { get; set; }

        public DbSet<Teams> Teams { get; set; }

    }
}
