using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace LivestreamE_Commerce
{
    [Dependency(ReplaceServices = true)]
    public class LivestreamE_CommerceBrandingProvider : DefaultBrandingProvider
    {
        public override string AppName => "LivestreamE_Commerce";
    }
}
