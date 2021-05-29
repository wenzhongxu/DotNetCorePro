using Abp.Application.Services;
using Abp.Pdnf.MultiTenancy.Dto;

namespace Abp.Pdnf.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

