using GuessMyNation.Core.ApplicationServices.GameHeaders;
using GuessMyNation.Core.Domain.Commands;
using GuessMyNation.Core.Domain.Game;
using GuessMyNation.Core.Domain.Nation;
using Microsoft.AspNetCore.Mvc;
using IActionResult = Microsoft.AspNetCore.Mvc.IActionResult;

namespace GuessMyNation.Endpoints.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class GameController : ControllerBase
    {
        private readonly GameHeaderApplicationService _gameHeaderApplicationService;

        public GameController(GameHeaderApplicationService gameHeaderApplicationService)
        {
            _gameHeaderApplicationService = gameHeaderApplicationService;
        }

        [HttpPost]
        [Route("CreateGame")]
        public IActionResult CreateGame(CreateGameCommand createGameCommand)
        {
            if (createGameCommand.PlayerId == 0)
               return BadRequest();
            var gameHeaderId = _gameHeaderApplicationService.CreateGame(createGameCommand);
            return Ok(gameHeaderId);
        }
        [HttpPost]
        [Route("Answer")]
        public IActionResult Answer(AnswerCommand answerCommand)
        {
            _gameHeaderApplicationService.Answer(answerCommand);
            return Ok();
        }

        [HttpGet("{gameHeaderId}")]
        public int GetTotalScore(GameCommand command)
        {
            return _gameHeaderApplicationService.GetTotalScore(command);
        }

        [HttpPost]
        [Route("FinishGame")]
        public IActionResult FinishGame(FinishGameCommand finishGameCommand)
        {
            _gameHeaderApplicationService.FinishGame(finishGameCommand);
            return Ok();
        }
    }
}
