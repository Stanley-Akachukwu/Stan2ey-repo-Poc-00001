using Blazored.LocalStorage;
using Blazored.Toast.Services;
using Microsoft.AspNetCore.Components;
using MudBlazor;
using RhinoWebUI.Client.Services.Interfaces;
using RhinoWebUI.Client.Services.Interfaces.Configurations;
using RhinoWebUI.Client.Shared;
using RhinoWebUI.Shared.DTO.Configurations;
using RhinoWebUI.Shared.Models.Configurations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RhinoWebUI.Client.Pages.Configurations
{
    public partial class Configurations
    {
        private Color color { get; set; }
        [Parameter]
        public int id { get; set; }
        private bool _loading;
        private IEnumerable<ConfigurationItem> configurationList = new List<ConfigurationItem>();
        [Inject] public ILocalStorageService _storageService { get; set; }
        [Inject] public NavigationManager _navigationManager { get; set; }
        [Inject] public IToastService _toastService { get; set; }
        [Inject] public IDialogService _dialogService { get; set; }
        [Inject] public IRhinoAPIConfigurationService _rhinoAPIConfiguration { get; set; }
        [Inject] public IOneTimeSetUpService _oneTimeSetUp { get; set; }
        public string ComponentTitle { get; set; }
        private MudTable<ConfigurationItem> mudTable;
        protected async override Task OnInitializedAsync()
        {
            _loading = true;
            await _storageService.SetItemAsync("AutomationAPIId", id);
            SetupParametersResponse response = await _oneTimeSetUp.SetUpParametersAsync();
            configurationList = await _rhinoAPIConfiguration.GetConfigurationsAsync();
            _loading = false;
        }
        protected override async Task OnParametersSetAsync()
        {

        }
        public void Refresh()
        {
            StateHasChanged();
        }
        private void ShowEditConfiguration(ConfigurationItem configurationItem)
        {
            _navigationManager.NavigateTo($"/editconfiguration/{configurationItem.Id}");
        }

        private void DeleteConfiguration(ConfigurationItem configurationItem)
        {
            var parameters = new DialogParameters();
            parameters.Add("ContentText", "Are you sure you want to delete");
            parameters.Add("IsDeletion", true);
            parameters.Add("ButtonText", "Yes");
            parameters.Add("Color", Color.Error);
            parameters.Add("ConfigurationItem", configurationItem);
            _dialogService.Show<ConfirmDialog>("Confirm", parameters);
        }
    }
}
