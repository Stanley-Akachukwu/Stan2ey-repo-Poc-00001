using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RhinoWebUI.Shared.Models
{
    public class ConnectorConfiguration
    {
        public string connector { get; set; }
        public string collection { get; set; }
        public string project { get; set; }
        public string userName { get; set; }
        public string password { get; set; }
        public bool asOsUser { get; set; }
        public bool attachScreenshot { get; set; }
        public bool bugManager { get; set; }
        public bool dryRun { get; set; }
    }
}
