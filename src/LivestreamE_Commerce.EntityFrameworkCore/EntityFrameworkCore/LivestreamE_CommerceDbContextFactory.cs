using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace LivestreamE_Commerce.EntityFrameworkCore
{
    /* This class is needed for EF Core console commands
     * (like Add-Migration and Update-Database commands) */
    public class LivestreamE_CommerceDbContextFactory : IDesignTimeDbContextFactory<LivestreamE_CommerceDbContext>
    {
        public LivestreamE_CommerceDbContext CreateDbContext(string[] args)
        {
            LivestreamE_CommerceEfCoreEntityExtensionMappings.Configure();

            var configuration = BuildConfiguration();

            var builder = new DbContextOptionsBuilder<LivestreamE_CommerceDbContext>()
                .UseSqlServer(configuration.GetConnectionString("Default"));

            return new LivestreamE_CommerceDbContext(builder.Options);
        }

        private static IConfigurationRoot BuildConfiguration()
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../LivestreamE_Commerce.DbMigrator/"))
                .AddJsonFile("appsettings.json", optional: false);

            return builder.Build();
        }
    }
}
