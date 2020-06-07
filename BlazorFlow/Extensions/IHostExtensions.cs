using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using BlazorFlow.Data;

namespace BlazorFlow.Extensions
{
    public static class IHostExtensions
    {
        public static IHost MigrateDatabase(this IHost host)
        {
            var env = Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT");

            if (env == "Production")
            {
                var serviceScopeFactory = (IServiceScopeFactory)host.Services.GetService(typeof(IServiceScopeFactory));

                using var scope = serviceScopeFactory.CreateScope();
                var services = scope.ServiceProvider;
                var dbContext = services.GetRequiredService<FlowContext>();
                dbContext.Database.Migrate();
            }

         return host;
        }
    }
}
