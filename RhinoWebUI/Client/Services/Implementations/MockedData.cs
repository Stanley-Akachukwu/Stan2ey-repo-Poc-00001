using RhinoWebUI.Shared.Enums;
using RhinoWebUI.Shared.Models;
using System.Collections.Generic;
using System.Linq;

namespace RhinoWebUI.Client.Services.Implementations
{
    public class MockedData : IMockedData
    {

        public List<APIAction> APIActions(int id)
        {
            var actions = new List<APIAction>()
        {
         new APIAction { Id=1,Name= "Delete Configurations", AutomationAPIId=11,ActionCategory=APIActionCategory.Setup,HttpVerb=HttpVerbs.Delete},
         new APIAction { Id=2,Name= "Delete All Collections", AutomationAPIId=11,ActionCategory=APIActionCategory.Setup,HttpVerb=HttpVerbs.Delete},
         new APIAction { Id=3,Name= "Create Configuration", AutomationAPIId=11,ActionCategory=APIActionCategory.Setup,HttpVerb=HttpVerbs.Post },
          new APIAction { Id=4,Name= "Create Tests Collection with Configuration", ActionCategory=APIActionCategory.Documentation,HttpVerb=HttpVerbs.Post},
         new APIAction { Id=5,Name= "Create Tests Collection", AutomationAPIId=11,ActionCategory=APIActionCategory.Documentation,HttpVerb=HttpVerbs.Post},
         new APIAction { Id=6,Name= "Get Associated Configurations", AutomationAPIId=11,ActionCategory=APIActionCategory.Documentation,HttpVerb=HttpVerbs.Get},
          new APIAction { Id=7,Name= "Get Tests Collection ByID", AutomationAPIId=11,ActionCategory=APIActionCategory.Documentation,HttpVerb=HttpVerbs.Get},
         new APIAction { Id=8,Name= "Get Tests Collection", AutomationAPIId=11,ActionCategory=APIActionCategory.Documentation,HttpVerb=HttpVerbs.Get},
         new APIAction { Id=9,Name= "Update Tests Collection",ActionCategory=APIActionCategory.Documentation,HttpVerb=HttpVerbs.Patch},
          new APIAction { Id=10,Name= "Update Associate Configuration with Collection", ActionCategory=APIActionCategory.Documentation,HttpVerb=HttpVerbs.Patch},
         new APIAction { Id=11,Name= "Delete Collection", AutomationAPIId=11,ActionCategory=APIActionCategory.Documentation,HttpVerb=HttpVerbs.Delete},
         new APIAction { Id=12,Name= "Delete All Collections", ActionCategory=APIActionCategory.Documentation,HttpVerb=HttpVerbs.Delete},

         new APIAction { Id=13,Name= "Delete Test Case Collections", ActionCategory=APIActionCategory.Setup,HttpVerb=HttpVerbs.Delete},
         new APIAction { Id=14,Name= "Delete Page Model Collections", ActionCategory=APIActionCategory.Setup,HttpVerb=HttpVerbs.Delete},
         new APIAction { Id=15,Name= "Delete Configurations", ActionCategory=APIActionCategory.Setup,HttpVerb=HttpVerbs.Delete},
         new APIAction { Id=16,Name= "Create Configuration - Local Driver", ActionCategory=APIActionCategory.Setup,HttpVerb=HttpVerbs.Post},
         new APIAction { Id=17,Name= "Create Collection", ActionCategory=APIActionCategory.Setup,HttpVerb=HttpVerbs.Post},

          new APIAction { Id=18,Name= "Invoke Collection by Configuration ID", AutomationAPIId=8,ActionCategory=APIActionCategory.Documentation,HttpVerb=HttpVerbs.Post},

           new APIAction { Id=19,Name= "Create Configuration", AutomationAPIId=2,ActionCategory=APIActionCategory.Documentation,HttpVerb=HttpVerbs.Post},
            new APIAction { Id=20,Name= "Get Configuration", AutomationAPIId=2,ActionCategory=APIActionCategory.Documentation,HttpVerb=HttpVerbs.Get},
             new APIAction { Id=21,Name= "Get Configurations", AutomationAPIId=2,ActionCategory=APIActionCategory.Documentation,HttpVerb=HttpVerbs.Get},
             new APIAction { Id=22,Name= "Update Configuration", AutomationAPIId=2,ActionCategory=APIActionCategory.Documentation,HttpVerb=HttpVerbs.Put},
            new APIAction { Id=23,Name= "Delete Configuration", AutomationAPIId=2,ActionCategory=APIActionCategory.Documentation,HttpVerb=HttpVerbs.Delete},
             new APIAction { Id=24,Name= "Delete Configurations", AutomationAPIId=2,ActionCategory=APIActionCategory.Documentation,HttpVerb=HttpVerbs.Delete},

              new APIAction { Id=25,Name= "SetUp Parameters", AutomationAPIId=1,ActionCategory=APIActionCategory.Setup,HttpVerb=HttpVerbs.Get},

        };
            return actions.Where(d => d.AutomationAPIId == id).ToList();
        }

        public List<AutomationAPI> GetAPIReferences()
        {
            return new List<AutomationAPI>
            {
                  //new AutomationAPI{Id=1,Name="One Time Setup",APIActions=APIActions(1),Route="/setup"},
                  new AutomationAPI{Id=2,Name="Configurations",APIActions=APIActions(2),Route="/configurations"} ,
                 // new AutomationAPI{Id=3,Name="Debug Automation"} ,
                 //new AutomationAPI{Id=4,Name="Environment"},
                 // new AutomationAPI{Id=5,Name="Logs & Analysis"},
                 //new AutomationAPI{Id=6,Name="Page Models"},
                 //new AutomationAPI{Id=7,Name="Plugins"},
                 //  new AutomationAPI{Id=8,Name="Rhino",APIActions=APIActions(8),Route="/rhino"},
                 //new AutomationAPI{Id=9,Name="Rhino Async"},
                 //new AutomationAPI{Id=10,Name="Meta Data"},
                 //  new AutomationAPI{Id=11,Name="Test Cases(Rhino Specs)",APIActions=APIActions(11),Route="/testcases"},
                 //new AutomationAPI{Id=12,Name="Utilities"},
            };
        }

    }
}
