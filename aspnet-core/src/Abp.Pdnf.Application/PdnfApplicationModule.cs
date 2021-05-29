using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Abp.Pdnf.Authorization;

namespace Abp.Pdnf
{
    [DependsOn(
        typeof(PdnfCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class PdnfApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<PdnfAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(PdnfApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddMaps(thisAssembly)
            );
        }
    }
}
