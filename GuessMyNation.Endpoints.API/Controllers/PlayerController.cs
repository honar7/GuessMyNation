using GuessMyNation.Core.ApplicationServices.Players;
using GuessMyNation.Core.Domain.Player;
using Microsoft.AspNetCore.Mvc;

namespace GuessMyNation.Endpoints.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PlayerController : ControllerBase
    {
        private readonly PlayerApplicationService _playerApplicationService;

        public PlayerController(PlayerApplicationService playerApplicationService)
        {
            _playerApplicationService = playerApplicationService;
        }

        [HttpPost]
        [Route("AddPlayer")]
        public IActionResult Add(Player player)
        {
            _playerApplicationService.Add(player);
            return Ok(player.Id);
        }

    }
}
