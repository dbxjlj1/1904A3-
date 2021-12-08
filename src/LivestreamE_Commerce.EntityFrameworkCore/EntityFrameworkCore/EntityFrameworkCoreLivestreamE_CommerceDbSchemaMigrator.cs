using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using LivestreamE_Commerce.Data;
using Volo.Abp.DependencyInjection;

namespace LivestreamE_Commerce.EntityFrameworkCore
{
    public class EntityFrameworkCoreLivestreamE_CommerceDbSchemaMigrator
        : ILivestreamE_CommerceDbSchemaMigrator, ITransientDependency
    {
        private readonly IServiceProvider _serviceProvider;

        public EntityFrameworkCoreLivestreamE_CommerceDbSchemaMigrator(
            IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public async Task MigrateAsync()
        {
            /* We intentionally resolving the LivestreamE_CommerceDbContext
             * from IServiceProvider (instead of directly injecting it)
             * to properly get the connection string of the current tenant in the
             * current scope.
             */

            await _serviceProvider
                .GetRequiredService<LivestreamE_CommerceDbContext>()
                .Database
                .MigrateAsync();
        }
    }
}
