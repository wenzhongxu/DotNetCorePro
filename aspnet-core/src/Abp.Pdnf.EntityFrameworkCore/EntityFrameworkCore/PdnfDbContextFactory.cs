using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using Abp.Pdnf.Configuration;
using Abp.Pdnf.Web;

namespace Abp.Pdnf.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class PdnfDbContextFactory : IDesignTimeDbContextFactory<PdnfDbContext>
    {
        public PdnfDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<PdnfDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            PdnfDbContextConfigurer.Configure(builder, configuration.GetConnectionString(PdnfConsts.ConnectionStringName));

            return new PdnfDbContext(builder.Options);
        }
    }
}
