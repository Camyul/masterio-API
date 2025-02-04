using Masterio.Server.Features.Identity;
using Microsoft.OpenApi.Models;

namespace Masterio.Server.Infrastructure
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services) =>
            services.AddTransient<IIdentityService, IdentityService>();

        public static IServiceCollection AddSwagger(this IServiceCollection services)
        => services.AddSwaggerGen(c =>
                    c.SwaggerDoc("v1", new OpenApiInfo { Title = "Masterio API", Version = "v1" }));

    }
}
