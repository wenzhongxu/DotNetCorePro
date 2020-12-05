using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using VODDY.Authorization.Roles;
using VODDY.Authorization.Users;
using VODDY.MultiTenancy;

namespace VODDY.EntityFrameworkCore
{
    public class VODDYDbContext : AbpZeroDbContext<Tenant, Role, User, VODDYDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public VODDYDbContext(DbContextOptions<VODDYDbContext> options)
            : base(options)
        {
        }
    }
}
