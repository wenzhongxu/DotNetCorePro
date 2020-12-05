using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using VODDY.Authorization;

namespace VODDY
{
    [DependsOn(
        typeof(VODDYCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class VODDYApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<VODDYAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(VODDYApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddMaps(thisAssembly)
            );
        }
    }
}
