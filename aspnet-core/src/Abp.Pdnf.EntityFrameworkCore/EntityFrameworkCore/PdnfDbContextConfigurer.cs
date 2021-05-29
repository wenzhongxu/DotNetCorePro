using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace Abp.Pdnf.EntityFrameworkCore
{
    public static class PdnfDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<PdnfDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<PdnfDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
