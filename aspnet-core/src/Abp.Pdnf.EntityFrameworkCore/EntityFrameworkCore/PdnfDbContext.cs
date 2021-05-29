using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using Abp.Pdnf.Authorization.Roles;
using Abp.Pdnf.Authorization.Users;
using Abp.Pdnf.MultiTenancy;

namespace Abp.Pdnf.EntityFrameworkCore
{
    public class PdnfDbContext : AbpZeroDbContext<Tenant, Role, User, PdnfDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public PdnfDbContext(DbContextOptions<PdnfDbContext> options)
            : base(options)
        {
        }
    }
}
