using BBB.DataAccess.Model.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace BBB.DataAccess.Model
{
    internal static class DI
    {
        public static IServiceCollection AddModel(this IServiceCollection services)
        {
            return services
                .AddDbContextFactory<WebContext>(options => options.UseSqlServer("name=ConnectionStrings:BBB"));
        }
    }
}
