namespace PontoEletronico.Permissions;

public static class PontoEletronicoPermissions
{
    public const string GroupName = "PontoEletronico";

    //Add your own permission names. Example:
    //public const string MyPermission1 = GroupName + ".MyPermission1";

    public static class Funcionarios
    {
        public const string Default = GroupName + ".Funcionarios";
        public const string Create = Default + ".Create";
        public const string Edit = Default + ".Edit";
        public const string Delete = Default + ".Delete";
    }

    public static class Setores
    {
        public const string Default = GroupName + ".Setores";
        public const string Create = Default + ".Create";
        public const string Edit = Default + ".Edit";
        public const string Delete = Default + ".Delete";
    }
}
