using Abp.Application.Features;
using Abp.Domain.Repositories;
using Abp.MultiTenancy;
using Abp.Pdnf.Authorization.Users;
using Abp.Pdnf.Editions;

namespace Abp.Pdnf.MultiTenancy
{
    public class TenantManager : AbpTenantManager<Tenant, User>
    {
        public TenantManager(
            IRepository<Tenant> tenantRepository, 
            IRepository<TenantFeatureSetting, long> tenantFeatureRepository, 
            EditionManager editionManager,
            IAbpZeroFeatureValueStore featureValueStore) 
            : base(
                tenantRepository, 
                tenantFeatureRepository, 
                editionManager,
                featureValueStore)
        {
        }
    }
}
