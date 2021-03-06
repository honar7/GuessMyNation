using Golrang.Framework.Domain;
using System;

namespace GuessMyNation.Core.Domain.Game
{
    public class GameHeader : BaseEntity
    {
        public GameHeader()
        {
            Details = new GameDetail();
        }
        public long PlayerId { get; set; }
        public DateTime StartDateTime { get; set; } =  DateTime.Now;
        public DateTime? EndDateTime { get; set; }
        public int TotalScore { get; set; }
        public GameDetail Details { get; set; }
    }
}
