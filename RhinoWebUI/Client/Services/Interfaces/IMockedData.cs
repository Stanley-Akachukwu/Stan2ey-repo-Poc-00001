
using RhinoWebUI.Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RhinoWebUI.Client.Services.Implementations
{
    public interface IMockedData
    {
        List<AutomationAPI> GetAPIReferences();
        List<APIAction> APIActions(int id);
    }
}
