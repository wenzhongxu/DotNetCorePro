using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Abp.Pdnf.Configuration;

namespace Abp.Pdnf.Web.Host.Startup
{
    [DependsOn(
       typeof(PdnfWebCoreModule))]
    public class PdnfWebHostModule: AbpModule
    {
        private readonly IWebHostEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public PdnfWebHostModule(IWebHostEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(PdnfWebHostModule).GetAssembly());
        }
    }
}
