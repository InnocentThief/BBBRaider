using BBB.Framework.Dto.Core;

namespace BBB.Business.Web
{
    public interface IPlayerDomain
    {
        Task<List<PlayerDto>> GetPlayersAsync();
    }
}
