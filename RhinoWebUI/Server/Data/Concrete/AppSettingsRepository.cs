using Microsoft.Extensions.Configuration;
using RhinoWebUI.Client.Services.Interfaces;
using RhinoWebUI.Server.Data.Abstract;

namespace RhinoWebUI.Server.Data.Concrete
{
    public class AppSettingsRepository: IAppSettingsRepository
    {
        public readonly IConfiguration _config;
        public AppSettingsRepository(IConfiguration config)
        {
            _config = config;
        }
        public string RhinoBasedUrl => _config["RhinoBasedUrl"];

        public string BasicAuthorization => _config["BasicAuthorization"];
    }
}
