using Gravity.Services.DataContracts;
using RhinoWebUI.Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RhinoWebUI.Shared.DTO.Configurations
{
    public class UpdateConfigurationRequest
    {
        public string name { get; set; }
        public List<object> testsRepository { get; set; }
        public List<DriverParameter> driverParameters { get; set; }
        public List<object> dataSource { get; set; }
        public List<object> models { get; set; }
        public Authentication authentication { get; set; }
        public EngineConfiguration engineConfiguration { get; set; }
        public ScreenshotsConfiguration screenshotsConfiguration { get; set; }
        public ReportConfiguration reportConfiguration { get; set; }

    }
 
}
