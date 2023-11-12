using BBB.DataAccess.Entity.Core;

namespace BBB.DataAccess.Repository
{
    internal interface IPlayerRepository
    {
        Task<List<Player>> GetPlayersAsync();
    }
}
