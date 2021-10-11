using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using RestSharp;
using RhinoWebUI.Server.Data.Abstract;
using RhinoWebUI.Shared.DTO.Configurations;
using RhinoWebUI.Shared.Models.Configurations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RhinoWebUI.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ConfigurationController : ControllerBase
    {
        private readonly IAppSettingsRepository _appSettings;
        public ConfigurationController(IAppSettingsRepository appSettings)
        {
            _appSettings = appSettings;
        }

        [HttpGet("list")]
        public async Task<IActionResult> GetList()
        {
            var configurationResponse = new ConfigurationResponse();
            var rhinoServiceUrl = _appSettings.RhinoBasedUrl + "configurations";
            var client = new RestClient(rhinoServiceUrl);
            client.Timeout = -1;
            var request = new RestRequest(Method.GET);
            request.AddHeader("Authorization", _appSettings.BasicAuthorization);
            IRestResponse response = client.Execute(request);
            var configurationResponseModel = JsonConvert.DeserializeObject<List<ConfigurationResponseModel>>(response.Content);


            configurationResponse.Succeeded = false;
            configurationResponse.ResponseMessage = "Failed to fetch configurations.";
            configurationResponse.ResponseCode = 404;
            if (response.IsSuccessful)
            {
                var configurationItems = await GetConfigs(configurationResponseModel);
                configurationResponse.Configurations = configurationItems.ToList();
                configurationResponse.Succeeded = true;
                configurationResponse.ResponseMessage = "Successfully fetched configurations.";
                configurationResponse.ResponseCode = 200;
            }
            return Ok(configurationResponse);
        }
        [HttpPost("update")]
        public async Task<IActionResult> UpdateConfigurationItem([FromBody]  ConfigurationItem configurationItem)
        {
            var configurationResponse = new ConfigurationResponse();
            var client = new RestClient(_appSettings.RhinoBasedUrl + "configurations/" + configurationItem.Id);
            client.Timeout = -1;
            var request = new RestRequest(Method.PUT);
            request.AddHeader("Authorization", _appSettings.BasicAuthorization);
            request.AddHeader("Content-Type", "application/json");
            var body = JsonConvert.SerializeObject(configurationItem);
            request.AddParameter("application/json", body, ParameterType.RequestBody);
            IRestResponse response = await client.ExecuteAsync(request);
            configurationResponse.Succeeded = false;
            configurationResponse.ResponseMessage = "Failed to update configurations.";
            configurationResponse.ResponseCode = 404;
            if (response.IsSuccessful)
            {
                var configurationItems = new List<ConfigurationItem>();
                configurationItems.Add(configurationItem);  
                configurationResponse.Configurations = configurationItems.ToList();
                configurationResponse.Succeeded = true;
                configurationResponse.ResponseMessage = "Update successfully executed.";
                configurationResponse.ResponseCode = 200;
            }
            return Ok(configurationResponse);
        }
        [HttpPost("deleteconfiguration")]
        public async Task<IActionResult> DeleteConfigurationItem(string id)
        {
            var configurationResponse = new ConfigurationResponse();
            var client = new RestClient(_appSettings.RhinoBasedUrl + "configurations/" + id);
            client.Timeout = -1;
            var request = new RestRequest(Method.DELETE);
            request.AddHeader("Authorization", _appSettings.BasicAuthorization);
            IRestResponse response = await client.ExecuteAsync(request);
            Console.WriteLine(response.Content);
            configurationResponse.Succeeded = false;
            configurationResponse.ResponseMessage = "Failed to delete configuration.";
            configurationResponse.ResponseCode = 404;
            if (response.IsSuccessful)
            {
                configurationResponse.Succeeded = true;
                configurationResponse.ResponseMessage = "Configuration deleted successfully.";
                configurationResponse.ResponseCode = 200;
            }
            return Ok(configurationResponse);
        }
        private async Task<IEnumerable<ConfigurationItem>> GetConfigs(List<ConfigurationResponseModel> models)
        {
            var configurations = new List<ConfigurationItem>();
            var items = new List<ConfigurationItem>();
            foreach (var model in models)
            {
                var elements = new List<Element>();
                var  tests = new List<Test>(); 
                var itemElements = model.Elements;
                var itemtests = model.Tests;

                if (itemElements.Count > 0)
                {
                    for (int i=0; i< itemElements.Count;i++)
                    {
                        var element = new Element()
                        {
                            ConfigurationItemId = Guid.Parse(model.Id),
                            ElementName = itemElements[i],
                            Index = i
                        };
                        elements.Add(element);
                    }

                }

                if (itemtests.Count > 0)
                {
                    for (int i = 0; i < itemtests.Count; i++)
                    {
                        var test = new Test()
                        {
                            ConfigurationItemId = Guid.Parse(model.Id),
                            TestItem = itemtests[i],
                            Index = i
                        };
                        tests.Add(test);
                    }

                }


                var item = new ConfigurationItem
                {
                    Elements = elements.ToList(),
                    Tests = tests.ToList(),
                    Id = Guid.Parse(model.Id),
                };
                items.Add(item);
            }

            #region

            //var items = new List<ConfigurationItem>()
            //{
            //    new ConfigurationItem
            //    {
            //        Id=Guid.Parse("213ae254-8d48-4f08-967e-1e70e8c894b7"),
            //        Elements= new List<Element>
            //        {
            //            new Element
            //            {
            //                ConfigurationItemId= Guid.Parse("213ae254-8d48-4f08-967e-1e70e8c894b7"),
            //                ElementName="Button",
            //                Index=0
            //            },
            //            new Element
            //            {
            //                ConfigurationItemId= Guid.Parse("213ae254-8d48-4f08-967e-1e70e8c894b7"),
            //                ElementName="Textbox",
            //                Index=1
            //            },
            //            new Element
            //            {
            //                ConfigurationItemId= Guid.Parse("213ae254-8d48-4f08-967e-1e70e8c894b7"),
            //                ElementName="Select",
            //                Index=2
            //            },
            //        },
            //        Tests= new List<Test>
            //        {
            //            new Test
            //            {
            //                ConfigurationItemId= Guid.Parse("213ae254-8d48-4f08-967e-1e70e8c894b7"),
            //                TestItem="[test-id] Text-000\r\n[test-scenario]\r\nOpen a Web Site\r\n[test-actions]\r\n1",
            //                Index=0
            //            },
            //            new Test
            //            {
            //                ConfigurationItemId= Guid.Parse("213ae254-8d48-4f08-967e-1e70e8c894b7"),
            //                TestItem="[test-id] Text-000\r\n[test-scenario]\r\nOpen a Web Site\r\n[test-actions]\r\n1",
            //                Index=1
            //            },
            //            new Test
            //            {
            //                ConfigurationItemId= Guid.Parse("213ae254-8d48-4f08-967e-1e70e8c894b7"),
            //                TestItem="[test-id] Text-000\r\n[test-scenario]\r\nOpen a Web Site\r\n[test-actions]\r\n1",
            //                Index=2
            //            },
            //        },
            //    },
            //      new ConfigurationItem
            //    {
            //        Id=Guid.Parse("213ae254-8d48-4f08-967e-1e70e8c894b6"),
            //        Elements= new List<Element>
            //        {
            //            new Element
            //            {
            //                ConfigurationItemId= Guid.Parse("213ae254-8d48-4f08-967e-1e70e8c894b6"),
            //                ElementName="Button",
            //                Index=0
            //            },
            //            new Element
            //            {
            //                ConfigurationItemId= Guid.Parse("213ae254-8d48-4f08-967e-1e70e8c894b6"),
            //                ElementName="Textbox",
            //                Index=1
            //            },
            //            new Element
            //            {
            //                ConfigurationItemId= Guid.Parse("213ae254-8d48-4f08-967e-1e70e8c894b6"),
            //                ElementName="Select",
            //                Index=2
            //            },
            //        },
            //        Tests= new List<Test>
            //        {
            //            new Test
            //            {
            //                ConfigurationItemId= Guid.Parse("213ae254-8d48-4f08-967e-1e70e8c894b6"),
            //                TestItem="[test-id] Text-000\r\n[test-scenario]\r\nOpen a Web Site\r\n[test-actions]\r\n1",
            //                Index=0
            //            },
            //            new Test
            //            {
            //                ConfigurationItemId= Guid.Parse("213ae254-8d48-4f08-967e-1e70e8c894b6"),
            //                TestItem="[test-id] Text-000\r\n[test-scenario]\r\nOpen a Web Site\r\n[test-actions]\r\n1",
            //                Index=1
            //            },
            //            new Test
            //            {
            //                ConfigurationItemId= Guid.Parse("213ae254-8d48-4f08-967e-1e70e8c894b6"),
            //                TestItem="[test-id] Text-000\r\n[test-scenario]\r\nOpen a Web Site\r\n[test-actions]\r\n1",
            //                Index=2
            //            },
            //        },
            //    },
            //};
            #endregion
            foreach (var item in items)
            {
                if (item != null)
                {
                    item.NumberOfElements = item.Elements.Count();
                    item.NumberOfTests = item.Tests.Count();
                    configurations.Add(item);
                }
            }
            return await Task.FromResult(configurations);
        }
    }
}
