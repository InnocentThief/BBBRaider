using Microsoft.EntityFrameworkCore;

namespace BBB.DataAccess.Model.Contexts
{
    internal sealed class WebContext : BaseDatabaseContext
    {
        public WebContext(DbContextOptions<WebContext> options) : base(options)
        {
        }
    }
}
