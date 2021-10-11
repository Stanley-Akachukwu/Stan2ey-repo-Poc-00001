using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RhinoWebUI.Shared.DTO.Configurations
{
    public class ConfigurationResponseModel
    {
        public string Id { get; set; }
        public List<string> Elements { get; set; }
        public List<string> Tests { get; set; }
    }
}
