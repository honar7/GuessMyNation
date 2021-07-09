using GuessMyNation.Core.Domain.Nation;

namespace GuessMyNation.Core.Domain.Game
{
    public interface GameHeaderRepository
    {
        void Add(GameHeader gameHeader, long playerId);
        void Answer(long GameHeaderId, NationItem nationItem);
        int GetTotalScore(long GameHeaderId);
        void FinishGame(long GameHeaderId);
    }
}
