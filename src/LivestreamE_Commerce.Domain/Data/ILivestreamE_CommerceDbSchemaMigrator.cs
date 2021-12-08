using System.Threading.Tasks;

namespace LivestreamE_Commerce.Data
{
    public interface ILivestreamE_CommerceDbSchemaMigrator
    {
        Task MigrateAsync();
    }
}
