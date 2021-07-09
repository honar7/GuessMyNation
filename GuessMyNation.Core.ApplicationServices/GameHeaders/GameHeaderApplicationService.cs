using GuessMyNation.Core.Domain.Game;

namespace GuessMyNation.Core.ApplicationServices.GameHeaders
{
    public class GameHeaderApplicationService
    { 
        private readonly GameHeaderRepository _gameHeaderRepository;

        public GameHeaderApplicationService(GameHeaderRepository gameHeaderRepository)
        {
          _gameHeaderRepository = gameHeaderRepository;
        }

        public void Add(GameHeader gameHeader, long playerId)
        {
            _gameHeaderRepository.Add(gameHeader, playerId);
        }

        public void Answer(long gameHeaderId, NationItem nationItem)
        {
            _gameHeaderRepository.Answer(gameHeaderId, nationItem);
        }
        public int GetTotalScore(long gameHeaderId)
        {
            return _gameHeaderRepository.GetTotalScore(gameHeaderId);

        }

        public void FinishGame(long gameHeaderId)
        {
            _gameHeaderRepository.FinishGame(gameHeaderId);
        }

    }
}
