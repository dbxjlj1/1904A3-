using LivestreamE_Commerce.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace LivestreamE_Commerce.Permissions
{
    public class LivestreamE_CommercePermissionDefinitionProvider : PermissionDefinitionProvider
    {
        public override void Define(IPermissionDefinitionContext context)
        {
            var myGroup = context.AddGroup(LivestreamE_CommercePermissions.GroupName);
            //Define your own permissions here. Example:
            //myGroup.AddPermission(LivestreamE_CommercePermissions.MyPermission1, L("Permission:MyPermission1"));
        }

        private static LocalizableString L(string name)
        {
            return LocalizableString.Create<LivestreamE_CommerceResource>(name);
        }
    }
}
