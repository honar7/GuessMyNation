using GuessMyNation.Core.Domain.Player;
using GuessMyNation.Infra.Data.Sql.Common;

namespace GuessMyNation.Infra.Data.Sql.Players
{
    public class EfPlayerRepository: PlayerRepository
    {
        private readonly GuessMyNationDbContext _GuessMyNationDb;

        public EfPlayerRepository(GuessMyNationDbContext GuessMyNationDb)
        {
            _GuessMyNationDb = GuessMyNationDb;
        }
        public void Add(Player player)
        {
            _GuessMyNationDb.Add(player);
            _GuessMyNationDb.SaveChanges();
        }

    }
}
