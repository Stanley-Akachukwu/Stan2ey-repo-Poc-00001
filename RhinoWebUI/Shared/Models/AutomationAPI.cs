using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RhinoWebUI.Shared.Models
{
    public class AutomationAPI
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Route { get; set; }
        public List<APIAction> APIActions { get; set; }
    }
}
