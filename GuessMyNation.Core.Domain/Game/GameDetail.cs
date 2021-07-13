using Golrang.Framework.Domain;
using GuessMyNation.Core.Domain.Nation;
using System.Collections.Generic;
using System.Linq;

namespace GuessMyNation.Core.Domain.Game
{
    public class GameDetail : BaseEntity
    {
        public GameDetail()
        {          
            NationItemAnswers = new HashSet<NationItemAnswer>();
        }
        public long GameHeaderId { get; set; }
       
        public ICollection<NationItemAnswer> NationItemAnswers { get; set; }
     

        public void AddNationItemAnswer(NationItemAnswer item)
        {
            NationItemAnswers.Add(item);
        }

        public int GetScores()
        {
            if (NationItemAnswers != null )
                NationItemAnswers.Sum(node => node.Point);   
            return 0;
        }
    }
}
