using Volo.Abp.Modularity;

namespace FS.Abp.Host.HttpApi
{
    [DependsOn(
        typeof(Volo.Abp.Account.HttpApi.AbpAccountHttpApiHostModule),
        typeof(Volo.Abp.Identity.HttpApi.AbpIdentityHttpApiHostModule),
        typeof(Volo.Abp.PermissionManagement.HttpApi.AbpPermissionManagementHttpApiHostModule),
        typeof(Volo.Abp.FeatureManagement.HttpApi.AbpFeatureManagementHttpApiHostModule),
        typeof(Volo.Abp.TenantManagement.HttpApi.AbpTenantManagementHttpApiHostModule)
        )]
    public class AbpHttpApiHostModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
        }
    }
}
