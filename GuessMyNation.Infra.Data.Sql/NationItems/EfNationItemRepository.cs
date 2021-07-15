using GuessMyNation.Core.Domain.Nation;
using GuessMyNation.Core.Domain.NationItems;
using GuessMyNation.Infra.Data.Sql.Common;
using Microsoft.EntityFrameworkCore;
using System;
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

        public List<NationItem> GetRandomly(int number) =>
            _GuessMyNationDb.NationItems
                 .Include(b => b.nation)
                 .Where(x => x.Path != null && x.AnswerCode == null)
                 .ToList().OrderBy(r => Guid.NewGuid()).Take(number).ToList();
    }
}
