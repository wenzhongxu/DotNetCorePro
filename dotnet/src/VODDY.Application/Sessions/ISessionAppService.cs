using System.Threading.Tasks;
using Abp.Application.Services;
using VODDY.Sessions.Dto;

namespace VODDY.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
