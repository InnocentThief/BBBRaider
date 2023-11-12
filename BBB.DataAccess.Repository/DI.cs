using BBB.DataAccess.Model;
using BBB.DataAccess.Repository.Core;
using Microsoft.Extensions.DependencyInjection;

namespace BBB.DataAccess.Repository
{
    internal static class DI
    {
        public static IServiceCollection AddWebRepositories(this IServiceCollection services)
        {
            return services
                .AddModel()
                .AddSingleton<IPlayerRepository, PlayerRepository>()
                .AddSingleton<IRaidRepository, RaidRepository>()
                .AddSingleton<IScheduleRepository, ScheduleRepository>();
        }
    }
}
