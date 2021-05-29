using Abp.AspNetCore;
using Abp.AspNetCore.TestBase;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Abp.Pdnf.EntityFrameworkCore;
using Abp.Pdnf.Web.Startup;
using Microsoft.AspNetCore.Mvc.ApplicationParts;

namespace Abp.Pdnf.Web.Tests
{
    [DependsOn(
        typeof(PdnfWebMvcModule),
        typeof(AbpAspNetCoreTestBaseModule)
    )]
    public class PdnfWebTestModule : AbpModule
    {
        public PdnfWebTestModule(PdnfEntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbContextRegistration = true;
        } 
        
        public override void PreInitialize()
        {
            Configuration.UnitOfWork.IsTransactional = false; //EF Core InMemory DB does not support transactions.
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(PdnfWebTestModule).GetAssembly());
        }
        
        public override void PostInitialize()
        {
            IocManager.Resolve<ApplicationPartManager>()
                .AddApplicationPartsIfNotAddedBefore(typeof(PdnfWebMvcModule).Assembly);
        }
    }
}