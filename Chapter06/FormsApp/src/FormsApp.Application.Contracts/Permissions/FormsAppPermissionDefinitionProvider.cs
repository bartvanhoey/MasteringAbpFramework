using FormsApp.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace FormsApp.Permissions;

public class FormsAppPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(FormsAppPermissions.GroupName);
        //Define your own permissions here. Example:
        //myGroup.AddPermission(FormsAppPermissions.MyPermission1, L("Permission:MyPermission1"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<FormsAppResource>(name);
    }
}
