using BBB.DataAccess.Entity.Core;
using Microsoft.EntityFrameworkCore;

namespace BBB.DataAccess.Model.Contexts
{
    internal sealed class WebContext : BaseDatabaseContext
    {
        public DbSet<Encounter> Encounter { get; set; }

        public DbSet<Player> Player { get; set; }

        public DbSet<Raid> Raid { get; set; }

        public DbSet<Participant> Participant { get; set; }

        public DbSet<Schedule> Schedule { get; set; }

        public WebContext(DbContextOptions<WebContext> options) : base(options)
        {
        }
    }
}
