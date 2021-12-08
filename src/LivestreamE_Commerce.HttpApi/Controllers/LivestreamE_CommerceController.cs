using LivestreamE_Commerce.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace LivestreamE_Commerce.Controllers
{
    /* Inherit your controllers from this class.
     */
    public abstract class LivestreamE_CommerceController : AbpController
    {
        protected LivestreamE_CommerceController()
        {
            LocalizationResource = typeof(LivestreamE_CommerceResource);
        }
    }
}