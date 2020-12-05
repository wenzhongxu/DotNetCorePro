using Abp.AspNetCore;
using Abp.AspNetCore.TestBase;
using Abp.Modules;
using Abp.Reflection.Extensions;
using VODDY.EntityFrameworkCore;
using VODDY.Web.Startup;
using Microsoft.AspNetCore.Mvc.ApplicationParts;

namespace VODDY.Web.Tests
{
    [DependsOn(
        typeof(VODDYWebMvcModule),
        typeof(AbpAspNetCoreTestBaseModule)
    )]
    public class VODDYWebTestModule : AbpModule
    {
        public VODDYWebTestModule(VODDYEntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbContextRegistration = true;
        } 
        
        public override void PreInitialize()
        {
            Configuration.UnitOfWork.IsTransactional = false; //EF Core InMemory DB does not support transactions.
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(VODDYWebTestModule).GetAssembly());
        }
        
        public override void PostInitialize()
        {
            IocManager.Resolve<ApplicationPartManager>()
                .AddApplicationPartsIfNotAddedBefore(typeof(VODDYWebMvcModule).Assembly);
        }
    }
}