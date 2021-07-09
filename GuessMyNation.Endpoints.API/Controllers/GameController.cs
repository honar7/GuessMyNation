using GuessMyNation.Core.ApplicationServices.GameHeaders;
using GuessMyNation.Core.Domain.Game;
using GuessMyNation.Core.Domain.Nation;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

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
        public IActionResult CreateGame(GameHeader gameHeader, long playerId)
        {
            _gameHeaderApplicationService.Add(gameHeader, playerId);
            return Ok();
        }
        [HttpPost]
        [Route("Answer")]
        public IActionResult Answer(long gameHeaderId, NationItem nationItem)
        {
            _gameHeaderApplicationService.Answer(gameHeaderId, nationItem);
            return Ok();
        }

        [HttpGet("{gameHeaderId}")]
        public int GetTotalScore(long gameHeaderId)
        {
            return _gameHeaderApplicationService.GetTotalScore(gameHeaderId);
        }

        [HttpPost]
        [Route("FinishGame")]
        public IActionResult FinishGame(long gameHeaderId)
        {
            _gameHeaderApplicationService.FinishGame(gameHeaderId);
            return Ok();
        }
    }
}
