using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using VODDY.Configuration.Dto;

namespace VODDY.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : VODDYAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
