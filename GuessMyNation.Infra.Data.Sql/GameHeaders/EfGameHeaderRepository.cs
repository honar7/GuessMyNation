using GuessMyNation.Core.Domain.Commands;
using GuessMyNation.Core.Domain.Game;
using GuessMyNation.Infra.Data.Sql.Common;
using Microsoft.EntityFrameworkCore;
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

        public void Answer(AnswerCommand  answerCommand)
        {
            var header = _GuessMyNationDb.Games.Include(head => head.Details)
                .FirstOrDefault(c => c.Id == answerCommand.GameHeaderId);         
           
              if (answerCommand.NationItemAnswer.NationId.Equals(answerCommand.NationItemAnswer.AnswerCode))
                  answerCommand.NationItemAnswer.Point = 20;
              else
                  answerCommand.NationItemAnswer.Point = -5;
              var detail = new GameDetail
                {
                    GameHeaderId = answerCommand.GameHeaderId  
                };

            header.Details.AddNationItemAnswer(answerCommand.NationItemAnswer);                     
            _GuessMyNationDb.SaveChanges();
        }

        public void FinishGame(FinishGameCommand finishGameCommand)
        {
            if (finishGameCommand.GameHeaderId > 0)
            {
                var header = _GuessMyNationDb.Games
                    .Include(head=> head.Details)
                    .ThenInclude(detail=>detail.NationItemAnswers)
                    .FirstOrDefault(c => c.Id == finishGameCommand.GameHeaderId);
                header.EndDateTime = DateTime.Now;
                if (header.Details!=null)
                {
                    header.TotalScore = header.Details.GetScores();
                }                
                _GuessMyNationDb.SaveChanges();
            }
        }

        public int GetTotalScore(GameCommand command)
        {
            var header = _GuessMyNationDb.Games
                .Include(head => head.Details)
                .FirstOrDefault(c => c.Id == command.GameHeaderId);
            header.TotalScore = header.Details.GetScores();
            _GuessMyNationDb.SaveChanges();
            return header.TotalScore;            
        }
    }
}
