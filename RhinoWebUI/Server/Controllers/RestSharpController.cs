using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RestSharp;
using System.Threading.Tasks;

namespace RhinoWebUI.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RestSharpController : ControllerBase
    {
        
        [HttpGet("todos")]
        public async Task<IActionResult> GetSarp()
        {
            var client = new RestClient("https://jsonplaceholder.typicode.com/todos");
            client.Timeout = -1;
            var request = new RestRequest(Method.GET);
            IRestResponse response = client.Execute(request);
            return Ok(response.Content);
        }
    }
}
