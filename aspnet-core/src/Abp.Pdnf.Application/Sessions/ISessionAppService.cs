using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Pdnf.Sessions.Dto;

namespace Abp.Pdnf.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
