using Volo.Abp.Modularity;

namespace LivestreamE_Commerce
{
    [DependsOn(
        typeof(LivestreamE_CommerceApplicationModule),
        typeof(LivestreamE_CommerceDomainTestModule)
        )]
    public class LivestreamE_CommerceApplicationTestModule : AbpModule
    {

    }
}