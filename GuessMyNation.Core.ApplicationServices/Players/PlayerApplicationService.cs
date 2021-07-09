using GuessMyNation.Core.Domain.Player;

namespace GuessMyNation.Core.ApplicationServices.Players
{
    public class PlayerApplicationService
    {
        private readonly PlayerRepository _playerRepository;

        public PlayerApplicationService(PlayerRepository playerRepository)
        {
            _playerRepository = playerRepository;
        }

        public void Add(Player player)
        {
            _playerRepository.Add(player);
        }

    }
}
