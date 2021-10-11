using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RhinoWebUI.Shared.Models
{
    public class ReportConfiguration
    {
        public List<string> reporters { get; set; }
        public object dataProvider { get; set; }
        public bool archive { get; set; }
        public bool localReport { get; set; }
        public bool addGravityData { get; set; }
    }
}
