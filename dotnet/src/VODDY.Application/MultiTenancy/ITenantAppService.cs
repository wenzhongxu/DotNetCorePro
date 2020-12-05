using Abp.Application.Services;
using VODDY.MultiTenancy.Dto;

namespace VODDY.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

