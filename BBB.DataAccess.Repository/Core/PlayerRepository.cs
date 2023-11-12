using BBB.DataAccess.Entity.Core;
using BBB.DataAccess.Model.Contexts;
using Microsoft.EntityFrameworkCore;

namespace BBB.DataAccess.Repository.Core
{
    internal sealed class PlayerRepository : BaseRepository, IPlayerRepository
    {
        public PlayerRepository(IDbContextFactory<WebContext> dbContextFactory) : base(dbContextFactory)
        {
        }

        public async Task<List<Player>> GetPlayersAsync()
        {
            await using var entities = await GetDatabaseContextAsync();
            return await entities.Player.AsNoTracking().ToListAsync();
        }
    }
}
