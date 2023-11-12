using BBB.DataAccess.Repository;
using BBB.Framework.Dto.Core;
using BBB.Framework.Conversion.Core;

namespace BBB.Business.Web.Core
{
    internal sealed class PlayerDomain : IPlayerDomain
    {
        private readonly IPlayerRepository playerRepository;

        public PlayerDomain(IPlayerRepository playerRepository)
        {
            this.playerRepository = playerRepository;
        }

        public async Task<List<PlayerDto>> GetPlayersAsync()
        {
            var players = await playerRepository.GetPlayersAsync();
            return players.ToDtos();
        }
    }
}
