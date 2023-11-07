using BBB.DataAccess.Repository;
using Microsoft.Extensions.DependencyInjection;

namespace BBB.Business.Web
{
    internal static class DI
    {
        public static IServiceCollection AddWebDomains(this IServiceCollection services)
        {
            return services
                .AddWebRepositories();
        }
    }
}
