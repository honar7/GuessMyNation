using GuessMyNation.Core.Domain.Commands;
using GuessMyNation.Core.Domain.Game;
using GuessMyNation.Core.Domain.Nation;

namespace GuessMyNation.Core.ApplicationServices.GameHeaders
{
    public class GameHeaderApplicationService
    { 
        private readonly GameHeaderRepository _gameHeaderRepository;

        public GameHeaderApplicationService(GameHeaderRepository gameHeaderRepository)
        {
          _gameHeaderRepository = gameHeaderRepository;
        }

        public long CreateGame(CreateGameCommand createGameCommand)
        {
            return _gameHeaderRepository.CreateGame(createGameCommand);
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
