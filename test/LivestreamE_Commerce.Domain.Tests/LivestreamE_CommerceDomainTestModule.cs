using LivestreamE_Commerce.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace LivestreamE_Commerce
{
    [DependsOn(
        typeof(LivestreamE_CommerceEntityFrameworkCoreTestModule)
        )]
    public class LivestreamE_CommerceDomainTestModule : AbpModule
    {

    }
}