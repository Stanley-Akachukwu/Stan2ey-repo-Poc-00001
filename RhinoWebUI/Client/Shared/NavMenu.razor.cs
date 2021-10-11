using Microsoft.AspNetCore.Components;
using RhinoWebUI.Client.Services.Implementations;
using RhinoWebUI.Shared.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace RhinoWebUI.Client.Shared
{
    public partial class NavMenu
    {
        public string notImplemented { get; set; } = "automation";
        public List<AutomationAPI> AutomationAPIs { get; set; }
        [Inject] public IMockedData _mockedData { get; set; }
        protected async override Task OnInitializedAsync()
        {
            AutomationAPIs = _mockedData.GetAPIReferences();
        }

    }
}
