using System.Threading.Tasks;
using deloso.Configuration.Dto;

namespace deloso.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
