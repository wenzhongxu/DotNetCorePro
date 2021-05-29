using Abp.MultiTenancy;
using Abp.Pdnf.Authorization.Users;

namespace Abp.Pdnf.MultiTenancy
{
    public class Tenant : AbpTenant<User>
    {
        public Tenant()
        {            
        }

        public Tenant(string tenancyName, string name)
            : base(tenancyName, name)
        {
        }
    }
}
