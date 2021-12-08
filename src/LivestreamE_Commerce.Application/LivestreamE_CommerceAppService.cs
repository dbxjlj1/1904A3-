using System;
using System.Collections.Generic;
using System.Text;
using LivestreamE_Commerce.Localization;
using Volo.Abp.Application.Services;

namespace LivestreamE_Commerce
{
    /* Inherit your application services from this class.
     */
    public abstract class LivestreamE_CommerceAppService : ApplicationService
    {
        protected LivestreamE_CommerceAppService()
        {
            LocalizationResource = typeof(LivestreamE_CommerceResource);
        }
    }
}
