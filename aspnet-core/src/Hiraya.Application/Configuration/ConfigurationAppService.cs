using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using Hiraya.Configuration.Dto;

namespace Hiraya.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : HirayaAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
