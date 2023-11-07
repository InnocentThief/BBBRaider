using BBB.DataAccess.Model;
using Microsoft.Extensions.DependencyInjection;

namespace BBB.DataAccess.Repository
{
    internal static class DI
    {
        public static IServiceCollection AddWebRepositories(this IServiceCollection services)
        {
            return services
                .AddModel();
        }
    }
}
