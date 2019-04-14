using System.Threading.Tasks;
using expensejar.Configuration.Dto;

namespace expensejar.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
