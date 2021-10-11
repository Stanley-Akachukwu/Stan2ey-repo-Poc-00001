using RhinoWebUI.Shared.Models.Configurations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RhinoWebUI.Shared.DTO.Configurations
{
    public class ConfigurationResponse:Response
    {
        public List<ConfigurationItem> Configurations {  get; set; }    
    }
}
