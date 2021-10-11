using RhinoWebUI.Shared.DTO.Configurations;
using System.Threading.Tasks;

namespace RhinoWebUI.Client.Services.Interfaces
{
    public interface IOneTimeSetUpService
    {
        Task<SetupParametersResponse> SetUpParametersAsync();
    }
}
