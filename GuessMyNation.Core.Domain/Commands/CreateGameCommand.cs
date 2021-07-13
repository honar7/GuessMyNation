using GuessMyNation.Core.Domain.Nation;

namespace GuessMyNation.Core.Domain.Commands
{
    public class CreateGameCommand
    {
        public long PlayerId { get; set; }
    }
    public class FinishGameCommand
    {
        public long GameHeaderId { get; set; }
    }
    public class GameCommand
    {
        public long GameHeaderId { get; set; }
    }

    public class AnswerCommand
    {
        public long GameHeaderId { get; set; }
        public NationItemAnswer NationItemAnswer { get; set; }       
    }
  
}
