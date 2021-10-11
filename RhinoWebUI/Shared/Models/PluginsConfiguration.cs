using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RhinoWebUI.Shared.Models
{
    public class PluginsConfiguration
    {
        public bool @public { get; set; }
        public string storageConnectionString { get; set; }
        public string storageProvider { get; set; }
    }
}
