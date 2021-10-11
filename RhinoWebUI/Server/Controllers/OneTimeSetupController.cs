using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RestSharp;
using RhinoWebUI.Server.Data.Abstract;
using RhinoWebUI.Shared.DTO.Configurations;
using System.Threading.Tasks;

namespace RhinoWebUI.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OneTimeSetupController : ControllerBase
    {
        private readonly IAppSettingsRepository _appSettings;
        public OneTimeSetupController(IAppSettingsRepository appSettings)
        {
            _appSettings = appSettings;
        }

        [HttpGet("setupparameters")]
        public async Task<IActionResult> GetSetupParameters()
        {
            var setupParametersResponse = new SetupParametersResponse();
            var rhinoServiceUrl = _appSettings.RhinoBasedUrl + "rhino";
            var client = new RestClient(rhinoServiceUrl);
            client.Timeout = -1;
            var request = new RestRequest(Method.GET);
            request.AddHeader("Authorization", _appSettings.BasicAuthorization);
            IRestResponse response = client.Execute(request);
            var ping = response.Content;

            setupParametersResponse.Succeeded = false;
            setupParametersResponse.ResponseMessage = " Failed Setup Parameters.";
            setupParametersResponse.ResponseCode = 404;
            if (response.IsSuccessful)
            {
                setupParametersResponse.PingResult=ping;
                setupParametersResponse.Succeeded = true;
                setupParametersResponse.ResponseMessage = "Successfully Setup Parameters.";
                setupParametersResponse.ResponseCode = 200;
            }
            return Ok(setupParametersResponse);
        }
    }
}
