using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RhinoWebUI.Shared.Models.Configurations
{
    public class ConfigurationItem 
    {
        public Guid Id { get; set; }
        public int NumberOfElements { get; set; }
        public int NumberOfTests { get; set; }
        public List<Element> Elements { get; set; }
        public List<Test> Tests { get; set; }
    }

    public class Element
    {
        public Guid ConfigurationItemId { get; set; }
        public string ElementName { get; set; }
        public int Index { get; set; }
    }
    public class Test
    {
        public Guid ConfigurationItemId { get; set; }
        public string TestItem { get; set; }
        public int Index { get; set; }
    }
}
