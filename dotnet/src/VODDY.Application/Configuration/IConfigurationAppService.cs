using System.Threading.Tasks;
using VODDY.Configuration.Dto;

namespace VODDY.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
