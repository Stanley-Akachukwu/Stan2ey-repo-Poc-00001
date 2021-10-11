using RhinoWebUI.Shared.DTO.Configurations;
using RhinoWebUI.Shared.Models.Configurations;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace RhinoWebUI.Client.Services.Interfaces.Configurations
{
    public interface IRhinoAPIConfigurationService
    {
        Task<IEnumerable<ConfigurationItem>> GetConfigurationsAsync();
        Task<ConfigurationItem> GetConfigurationItemAsync(string id);
        Task<ConfigurationResponse> UpdateConfigurationsAsync(ConfigurationItem configurationItem);
        Task<ConfigurationResponse> DeleteConfigurationItemAsync(string id);

    }
}
