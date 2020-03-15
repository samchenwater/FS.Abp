using Volo.Abp.Modularity;

namespace Volo.Abp.Account.HttpApi
{
    [DependsOn(
        typeof(AbpAccountApplicationModule),
        typeof(AbpAccountHttpApiModule)
        )]
    public class AbpAccountHttpApiHostModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
        }
    }
}
