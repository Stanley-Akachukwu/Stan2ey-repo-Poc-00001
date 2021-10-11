using Gravity.Services.DataContracts;
using RhinoWebUI.Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RhinoWebUI.Shared.DTO.Configurations
{
    public class UpdateConfigurationResponse
    {
        public string id { get; set; }
        public string name { get; set; }
        public int attempts { get; set; }
        public List<object> testsRepository { get; set; }
        public string integration { get; set; }
        public List<DriverParameter> driverParameters { get; set; }
        public List<object> dataSource { get; set; }
        public List<object> models { get; set; }
        public List<object> categories { get; set; }
        public List<object> serviceHooks { get; set; }
        public string gravityEndpoint { get; set; }
        public Authentication authentication { get; set; }
        public EngineConfiguration engineConfiguration { get; set; }
        public ScreenshotsConfiguration screenshotsConfiguration { get; set; }
        public ReportConfiguration reportConfiguration { get; set; }
        public PluginsConfiguration pluginsConfiguration { get; set; }
        public ConnectorConfiguration connectorConfiguration { get; set; }
        public Capabilities capabilities { get; set; }

    }
 
}
