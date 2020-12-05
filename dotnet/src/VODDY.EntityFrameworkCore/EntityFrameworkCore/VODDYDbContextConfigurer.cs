using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace VODDY.EntityFrameworkCore
{
    public static class VODDYDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<VODDYDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<VODDYDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
