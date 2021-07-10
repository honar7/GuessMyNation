using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessMyNation.Core.Domain.Commands
{
    public class CreateGameCommand
    {
        public long PlayerId { get; set; }
    }
}
