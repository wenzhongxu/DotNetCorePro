using System.Threading.Tasks;
using Abp.Pdnf.Configuration.Dto;

namespace Abp.Pdnf.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
