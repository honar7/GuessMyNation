using GuessMyNation.Core.Domain.Commands;
using GuessMyNation.Core.Domain.Game;
using GuessMyNation.Core.Domain.Nation;
using GuessMyNation.Infra.Data.Sql.Common;
using System;
using System.Linq;

namespace GuessMyNation.Infra.Data.Sql.GameHeaders
{
    public class EfGameHeaderRepository: GameHeaderRepository
    {
        private readonly GuessMyNationDbContext _GuessMyNationDb;

        public EfGameHeaderRepository(GuessMyNationDbContext GuessMyNationDb)
        {
            _GuessMyNationDb = GuessMyNationDb;
        }
     
        public long CreateGame(CreateGameCommand createGameCommand)
        {
            var player = _GuessMyNationDb.Players.FirstOrDefault(c => c.Id == createGameCommand.PlayerId);
            if (player == null)
                Console.WriteLine("player Not Found: {0}", createGameCommand.PlayerId);
            GameHeader header = new GameHeader();
            header.PlayerId = createGameCommand.PlayerId;
            header.StartDateTime = DateTime.Now;
            header.TotalScore = 0;
            _GuessMyNationDb.Games.Add(header);
            _GuessMyNationDb.SaveChanges();                 
            return header.Id;
        }

        private void Exception()
        {
            throw new NotImplementedException();
        }

        public void Answer(long GameHeaderId, NationItem nationItem)
        {
            var header = _GuessMyNationDb.Games.FirstOrDefault(c => c.Id == GameHeaderId);
            var detail = new GameDetail();
            detail.GameHeaderId = GameHeaderId;
            detail.nationItems.Add(nationItem);
            if (nationItem.AnswerCode != null)
            {
                if (nationItem.nation.Equals(nationItem.AnswerCode))
                    nationItem.Point = 20;
                else
                    nationItem.Point = -5;

                header.Details.AddNationItem(nationItem);
            }            
            _GuessMyNationDb.SaveChanges();
        }

        public void FinishGame(long GameHeaderId)
        {
            var header = _GuessMyNationDb.Games.FirstOrDefault(c => c.Id == GameHeaderId);
            header.EndDateTime = new DateTime();
            _GuessMyNationDb.SaveChanges();
        }

        public int GetTotalScore(long GameHeaderId)
        {
            var header = _GuessMyNationDb.Games.FirstOrDefault(c => c.Id == GameHeaderId);
            header.TotalScore = header.Details.GetScores();
            _GuessMyNationDb.SaveChanges();
            return header.TotalScore;            
        }
    }
}
