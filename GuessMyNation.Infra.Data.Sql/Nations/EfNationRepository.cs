using GuessMyNation.Core.Domain.Nation;
using GuessMyNation.Infra.Data.Sql.Common;
using System.Collections.Generic;
using System.Linq;

namespace GuessMyNation.Infra.Data.Sql.Nations
{
    public class EfNationRepository : NationRepository
    {
        private readonly GuessMyNationDbContext _GuessMyNationDb;

        public EfNationRepository(GuessMyNationDbContext GuessMyNationDb)
        {
            _GuessMyNationDb = GuessMyNationDb;
        }
        public void Add(Nation nation)
        {
            _GuessMyNationDb.Add(nation);
            _GuessMyNationDb.SaveChanges();
        }

        public Nation Get(int nationId)
        {
            return _GuessMyNationDb.Nations.FirstOrDefault(c => c.Id == nationId);
        }

        public List<Nation> Get()
        {
            return _GuessMyNationDb.Nations.ToList();
        }

        public void Remove(int blogId)
        {
            var nation = new Nation
            {
                Id = blogId
            };
            _GuessMyNationDb.Nations.Remove(nation);
            _GuessMyNationDb.SaveChanges();
        }
    }
}
