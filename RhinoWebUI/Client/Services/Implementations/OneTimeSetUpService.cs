using Microsoft.AspNetCore.Components.WebAssembly.Http;
using RhinoWebUI.Client.Services.Interfaces;
using RhinoWebUI.Shared.DTO.Configurations;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace RhinoWebUI.Client.Services.Implementations
{
    public class OneTimeSetUpService : IOneTimeSetUpService
    {
        private readonly HttpClient _httpClient;
        IHttpClientFactory _clientFacotry;
        public OneTimeSetUpService(HttpClient httpClient, IHttpClientFactory clientFacotry)
        {
            _httpClient = httpClient;
            _clientFacotry = clientFacotry;
        }

        public async Task<SetupParametersResponse> SetUpParametersAsync()
        {

            var response = await _httpClient.GetAsync("api/onetimesetup/setupparameters");
            var pongResult = await response.Content.ReadFromJsonAsync<SetupParametersResponse>();
            return pongResult;
        }
    }
}
