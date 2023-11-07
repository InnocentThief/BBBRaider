using BBB.Business.Web;

namespace BBB.Services.Web
{
    internal static class DI
    {
        public static IServiceCollection ConfigureServices(this IServiceCollection services)
        {
            return services
                .AddWebDomains();
        }
    }
}
