using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace HomeAutomation.Models.Context
{
    public static class DatabaseUpdateMigrator
    {
        public static void Migrate(IServiceProvider serviceProvider)
        {
            using (var serviceScope = serviceProvider.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<ApplicationDbContext>();

                context.Database.Migrate();
            }
        }
    }
}
