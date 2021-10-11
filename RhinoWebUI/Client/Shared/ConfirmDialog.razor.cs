using Blazored.Toast.Services;
using Microsoft.AspNetCore.Components;
using MudBlazor;
using RhinoWebUI.Client.Services.Interfaces.Configurations;
using RhinoWebUI.Shared.Models.Configurations;

namespace RhinoWebUI.Client.Shared
{
    public partial class ConfirmDialog
    {
        [CascadingParameter] MudDialogInstance MudDialog { get; set; }
        [Parameter] public string ContentText { get; set; }
        [Parameter] public bool IsDeletion { get; set; }
        [Parameter] public string ButtonText { get; set; }
        [Parameter] public ConfigurationItem configurationItem { get; set; } = new ConfigurationItem();
        [Inject] public NavigationManager _navigationManager { get; set; }
        [Inject] public IToastService _toastService { get; set; }
        [Inject] public IRhinoAPIConfigurationService _rhinoAPIConfiguration { get; set; }
        [Parameter] public Color Color { get; set; }

        private void Cancel()
        {
            MudDialog.Cancel();
        }
        private async void ConfirmAction()
        {
            if (IsDeletion)
            {
                DialogResult.Ok(true);
                _rhinoAPIConfiguration.DeleteConfigurationItemAsync(configurationItem.Id.ToString());
                _toastService.ShowSuccess(configurationItem.Id.ToString() + " configuration has been deleted!");
                //if (createTermedDepositResponse.Succeeded == true)
                //{
                //    _toastService.ShowSuccess(createTermedDepositResponse.ResponseMessage);
                //}
                //else
                //{
                //    _toastService.ShowError(createTermedDepositResponse.ResponseMessage);
                //}
                _navigationManager.NavigateTo($"/configurations");
            }
        }

    }
}
