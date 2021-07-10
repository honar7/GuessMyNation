using GuessMyNation.Core.Domain.Commands;
using GuessMyNation.Core.Domain.Nation;

namespace GuessMyNation.Core.Domain.Game
{
    public interface GameHeaderRepository
    {
        long CreateGame(CreateGameCommand createGameCommand);
        void Answer(long GameHeaderId, NationItem nationItem);
        int GetTotalScore(long GameHeaderId);
        void FinishGame(long GameHeaderId);
    }
}
