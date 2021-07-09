using GuessMyNation.Core.Domain.Game;
using GuessMyNation.Core.Domain.Nation;
using GuessMyNation.Core.Domain.Player;
using Microsoft.EntityFrameworkCore;

namespace GuessMyNation.Infra.Data.Sql.Common
{
    public class GuessMyNationDbContext : DbContext
    {
        public GuessMyNationDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Nation> Nations { get; set; }
        public DbSet<Player> Players { get; set; }
        public DbSet<GameHeader> Games { get; set; }
        public DbSet<NationItem> NationItems { get; set; }        

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(GetType().Assembly);
        }
    }
}
