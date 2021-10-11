using Newtonsoft.Json;
using RhinoWebUI.Client.Services.Interfaces;
using RhinoWebUI.Client.Services.Interfaces.Configurations;
using RhinoWebUI.Shared.DTO.Configurations;
using RhinoWebUI.Shared.Models.Configurations;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace RhinoWebUI.Client.Services.Implementations.Configurations
{
    public class RhinoAPIConfigurationService : IRhinoAPIConfigurationService
    {
        private readonly HttpClient _httpClient;
        public RhinoAPIConfigurationService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task<IEnumerable<ConfigurationItem>> GetConfigurationsAsync()
        {

            var configurationResponse = new ConfigurationResponse();
            var configurationItems = new List<ConfigurationItem>(); 
            var response = await _httpClient.GetAsync("api/configuration/list");
            configurationResponse = await response.Content.ReadFromJsonAsync<ConfigurationResponse>();
            if(configurationResponse == null)
            {
                return null;
            }
            configurationItems= configurationResponse.Configurations;
            return configurationItems;
        }
        public async Task<ConfigurationItem> GetConfigurationItemAsync(string id)
        {
            var configurationResponse = new ConfigurationResponse();
            var configurationItem = new ConfigurationItem();
            var response = await _httpClient.GetAsync("api/configuration/list");
            configurationResponse = await response.Content.ReadFromJsonAsync<ConfigurationResponse>();
            if (configurationResponse == null)
            {
                return null;
            }
          var  configurationItems = configurationResponse.Configurations;

            return configurationItems.FirstOrDefault(x => x.Id.ToString() == id);
        }

      


        public async Task<ConfigurationResponse> UpdateConfigurationsAsync(ConfigurationItem configurationItem)
        {

            var configurationResponse = new ConfigurationResponse();
            try
            {
                var response = await _httpClient.PostAsJsonAsync("api/configuration/update", configurationItem);
                if (response.IsSuccessStatusCode)
                {
                    configurationResponse = await response.Content.ReadFromJsonAsync<ConfigurationResponse>();
                }
            }
            catch (Exception ex)
            {
                configurationResponse = null;
            }
             return configurationResponse;
        }

        public async Task<ConfigurationResponse> DeleteConfigurationItemAsync(string id)
        {
            var configurationResponse = new ConfigurationResponse();
            try
            {
                var response = await _httpClient.DeleteAsync($"api/configuration/deleteconfiguration/{id}");
                if (response.IsSuccessStatusCode)
                {
                    configurationResponse = await response.Content.ReadFromJsonAsync<ConfigurationResponse>();
                }
            }
            catch (Exception ex)
            {
                configurationResponse = null;
            }
            return configurationResponse;
        }

        //private async Task<UpdateConfigurationRequest> GetUpdateConfigurationRequest(ConfigurationItem configurationItem)
        //{
        //    var updateJSONString = File.ReadAllText(Path.Combine(Directory.GetCurrentDirectory(), $"wwwroot\\{"JsonData\\UpdateConfigurationRequest.json"}"));
        //    var updateConfigurationRequest = JsonConvert.DeserializeObject<UpdateConfigurationRequest>(updateJSONString);
        //    Console.WriteLine(updateConfigurationRequest);
        //    return updateConfigurationRequest;
        //}
    }
}
