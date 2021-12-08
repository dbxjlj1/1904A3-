using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace LivestreamE_Commerce.Data
{
    /* This is used if database provider does't define
     * ILivestreamE_CommerceDbSchemaMigrator implementation.
     */
    public class NullLivestreamE_CommerceDbSchemaMigrator : ILivestreamE_CommerceDbSchemaMigrator, ITransientDependency
    {
        public Task MigrateAsync()
        {
            return Task.CompletedTask;
        }
    }
}