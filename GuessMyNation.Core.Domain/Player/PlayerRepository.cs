using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessMyNation.Core.Domain.Player
{
    public interface PlayerRepository
    {
        void Add(Player player);
    }
}
