using GuessMyNation.Core.Domain.Nation;
using GuessMyNation.Core.Domain.NationItems;
using GuessMyNation.Infra.Data.Sql.Common;
using System.Collections.Generic;
using System.Linq;

namespace GuessMyNation.Infra.Data.Sql.NationItems
{
    public class EfNationItemRepository : NationItemRepository
    {
        private readonly GuessMyNationDbContext _GuessMyNationDb;

        public EfNationItemRepository(GuessMyNationDbContext GuessMyNationDb)
        {
            _GuessMyNationDb = GuessMyNationDb;
        }

        public List<NationItem> GetRandomly(int number)
        {
            //return (List<NationItem>)_GuessMyNationDb.NationItems.ToList().OrderBy(r => r.Id).Take(number);
            return _GuessMyNationDb.NationItems.ToList().OrderBy(node => node.Id).Take(number).ToList();
        }
    }
}
