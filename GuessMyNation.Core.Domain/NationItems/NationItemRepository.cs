using GuessMyNation.Core.Domain.Nation;
using System.Collections.Generic;

namespace GuessMyNation.Core.Domain.NationItems
{
    public interface NationItemRepository
    {
        List<NationItem> GetRandomly(int number);
    }
}
