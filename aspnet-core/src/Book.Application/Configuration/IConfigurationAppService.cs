using System.Threading.Tasks;
using Book.Configuration.Dto;

namespace Book.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
