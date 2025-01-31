using Masterio.Server.Data;
using Microsoft.EntityFrameworkCore;

namespace Masterio.Server.Infrastructure
{
    public static class ApplicationBuilderExtensions
    {
        public static void ApplyMigrations(this IApplicationBuilder app)
        {
            using var services = app.ApplicationServices.CreateScope();
            var dbContext = services.ServiceProvider.GetService<MasterioDbContext>();
            dbContext.Database.Migrate();
        }
    }
}
