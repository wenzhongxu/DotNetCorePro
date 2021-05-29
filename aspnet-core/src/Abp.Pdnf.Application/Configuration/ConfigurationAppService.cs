using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using Abp.Pdnf.Configuration.Dto;

namespace Abp.Pdnf.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : PdnfAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
