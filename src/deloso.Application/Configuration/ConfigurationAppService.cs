using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using deloso.Configuration.Dto;

namespace deloso.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : delosoAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
