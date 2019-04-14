using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using expensejar.Authorization;

namespace expensejar
{
    [DependsOn(
        typeof(expensejarCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class expensejarApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<expensejarAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(expensejarApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddProfiles(thisAssembly)
            );
        }
    }
}
