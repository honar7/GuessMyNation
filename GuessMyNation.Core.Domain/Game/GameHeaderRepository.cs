using GuessMyNation.Core.Domain.Commands;

namespace GuessMyNation.Core.Domain.Game
{
    public interface GameHeaderRepository
    {
        long CreateGame(CreateGameCommand createGameCommand);
        void Answer(AnswerCommand command);
        int GetTotalScore(GameCommand command);
        void FinishGame(FinishGameCommand finishGameCommand);
    }
}
