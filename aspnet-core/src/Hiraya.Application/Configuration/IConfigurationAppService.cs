using System.Threading.Tasks;
using Hiraya.Configuration.Dto;

namespace Hiraya.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
