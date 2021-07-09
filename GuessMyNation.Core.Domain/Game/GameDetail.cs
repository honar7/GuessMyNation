using Golrang.Framework.Domain;
using GuessMyNation.Core.Domain.Nation;
using System.Collections.Generic;
using System.Linq;

namespace GuessMyNation.Core.Domain.Game
{
    public class GameDetail : BaseEntity
    {
        public long GameHeaderId { get; set; }
        public List<NationItem> nationItems { get; set; }

        public void AddNationItem(NationItem item)
        {
            nationItems.Add(item);
        }

        public int GetScores()
        {
            if (nationItems!= null && nationItems.Count() > 0)
                nationItems.Sum(node => node.Point);             
            else
                return 0;
            return 0;
        }
    }
}
