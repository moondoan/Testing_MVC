using Abp.Authorization;
using Abp.Localization;
using Abp.MultiTenancy;

namespace Sp.AvSec.Authorization
{
    public class AvSecAuthorizationProvider : AuthorizationProvider
    {
        public override void SetPermissions(IPermissionDefinitionContext context)
        {
            context.CreatePermission(PermissionNames.Pages_Users, L("Users"));
            context.CreatePermission(PermissionNames.Pages_Roles, L("Roles"));
            context.CreatePermission(PermissionNames.Pages_Tenants, L("Tenants"), multiTenancySides: MultiTenancySides.Host);

            context.CreatePermission(PermissionNames.Pages_PrintBatches, L("PrintBatches"));
            context.CreatePermission(PermissionNames.Pages_CardTemplates, L("CardTemplates"));
        }

        private static ILocalizableString L(string name)
        {
            return new LocalizableString(name, AvSecConsts.LocalizationSourceName);
        }
    }
}
