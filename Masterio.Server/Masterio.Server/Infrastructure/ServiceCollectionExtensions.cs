using Masterio.Server.Features.Identity;

namespace Masterio.Server.Infrastructure
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services) =>
            services.AddTransient<IIdentityService, IdentityService>();



    }
}
