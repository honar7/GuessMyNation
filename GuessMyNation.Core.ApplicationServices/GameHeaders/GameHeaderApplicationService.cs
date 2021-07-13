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

        public void Answer(AnswerCommand answerCommand)
        {
            _gameHeaderRepository.Answer(answerCommand);
        }
        public int GetTotalScore(GameCommand command)
        {
            return _gameHeaderRepository.GetTotalScore(command);

        }

        public void FinishGame(FinishGameCommand finishGameCommand)
        {
            _gameHeaderRepository.FinishGame(finishGameCommand);
        }

    }
}
