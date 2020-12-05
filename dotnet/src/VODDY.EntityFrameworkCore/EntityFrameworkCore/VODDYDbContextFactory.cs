using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using VODDY.Configuration;
using VODDY.Web;

namespace VODDY.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class VODDYDbContextFactory : IDesignTimeDbContextFactory<VODDYDbContext>
    {
        public VODDYDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<VODDYDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            VODDYDbContextConfigurer.Configure(builder, configuration.GetConnectionString(VODDYConsts.ConnectionStringName));

            return new VODDYDbContext(builder.Options);
        }
    }
}
