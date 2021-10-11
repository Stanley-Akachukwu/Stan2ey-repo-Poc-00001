using Blazored.LocalStorage;
using Blazored.Toast;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using MudBlazor.Services;
using RhinoWebUI.Client.Services;
using RhinoWebUI.Client.Services.Implementations;
using RhinoWebUI.Client.Services.Implementations.Configurations;
using RhinoWebUI.Client.Services.Interfaces;
using RhinoWebUI.Client.Services.Interfaces.Configurations;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace RhinoWebUI.Client
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("#app");
            builder.Services.AddBlazoredToast();
            builder.Services.AddOptions();
            builder.Services.AddMudServices();
            builder.Services.AddBlazoredLocalStorage();
            builder.Services.AddHttpClient();


            builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

            builder.Services.AddScoped<IMockedData, MockedData>();
            builder.Services.AddScoped<IRhinoAPIConfigurationService, RhinoAPIConfigurationService>();
            builder.Services.AddScoped<IOneTimeSetUpService, OneTimeSetUpService>();

            await builder.Build().RunAsync();
        }
    }
}
