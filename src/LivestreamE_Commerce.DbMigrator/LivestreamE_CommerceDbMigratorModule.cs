using LivestreamE_Commerce.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.BackgroundJobs;
using Volo.Abp.Modularity;

namespace LivestreamE_Commerce.DbMigrator
{
    [DependsOn(
        typeof(AbpAutofacModule),
        typeof(LivestreamE_CommerceEntityFrameworkCoreModule),
        typeof(LivestreamE_CommerceApplicationContractsModule)
        )]
    public class LivestreamE_CommerceDbMigratorModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<AbpBackgroundJobOptions>(options => options.IsJobExecutionEnabled = false);
        }
    }
}
