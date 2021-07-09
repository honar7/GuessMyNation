using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessMyNation.Core.Domain.Nation
{
    public interface NationRepository
    {
        void Add(Nation nation);
        void Remove(int nationId);
        Nation Get(int nationId);
        List<Nation> Get();
    }
}
