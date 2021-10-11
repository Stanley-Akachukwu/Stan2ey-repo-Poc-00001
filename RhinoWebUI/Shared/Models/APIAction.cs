using RhinoWebUI.Shared.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RhinoWebUI.Shared.Models
{
    public class APIAction
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int AutomationAPIId { get; set; }
        public APIActionCategory ActionCategory { get; set; }
        public HttpVerbs HttpVerb { get; set; }
        public ConfigurationComponents ConfigurationComponent { get; set; }
    }
}
