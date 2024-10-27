using PontoEletronico.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace PontoEletronico.Permissions;

public class PontoEletronicoPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var pontoEletronicoGroup = context.AddGroup(PontoEletronicoPermissions.GroupName, L("Permission:PontoEletronico"));

        var pontoEletronicoPermission = pontoEletronicoGroup.AddPermission(PontoEletronicoPermissions.Funcionarios.Default, L("Permission:Funcionarios"));
        pontoEletronicoPermission.AddChild(PontoEletronicoPermissions.Funcionarios.Create, L("Permission:Funcionarios.Create"));
        pontoEletronicoPermission.AddChild(PontoEletronicoPermissions.Funcionarios.Edit, L("Permission:Funcionarios.Edit"));
        pontoEletronicoPermission.AddChild(PontoEletronicoPermissions.Funcionarios.Delete, L("Permission:Funcionarios.Delete"));

        var setoresPermission = pontoEletronicoGroup.AddPermission(PontoEletronicoPermissions.Setores.Default, L("Permission:Setores"));
        pontoEletronicoPermission.AddChild(PontoEletronicoPermissions.Setores.Create, L("Permission:Setores.Create"));
        pontoEletronicoPermission.AddChild(PontoEletronicoPermissions.Setores.Edit, L("Permission:Setores.Edit"));
        pontoEletronicoPermission.AddChild(PontoEletronicoPermissions.Setores.Delete, L("Permission:Setores.Delete"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<PontoEletronicoResource>(name);
    }
}
