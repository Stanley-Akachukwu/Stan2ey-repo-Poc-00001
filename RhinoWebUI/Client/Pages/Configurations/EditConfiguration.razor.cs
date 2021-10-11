using Blazored.LocalStorage;
using Blazored.Toast.Services;
using Microsoft.AspNetCore.Components;
using MudBlazor;
using RhinoWebUI.Client.Services.Interfaces.Configurations;
using RhinoWebUI.Shared.DTO.Configurations;
using RhinoWebUI.Shared.Models.Configurations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RhinoWebUI.Client.Pages.Configurations
{
    public partial class EditConfiguration
    {
        [Parameter]
        public string SelectedComponent { get; set; }
        public bool success;
        public bool isBusy = false;
        [Parameter]
        public string id { get; set; }
        private ConfigurationItem configurationItem = new ConfigurationItem();
        [Inject] public IDialogService _dialogService { get; set; }
        [Inject] public IRhinoAPIConfigurationService _rhinoAPIConfiguration { get; set; }
        [Inject] public NavigationManager _navigationManager { get; set; }
        [Inject] public IToastService _toastService { get; set; }
        [Inject] public ILocalStorageService _storageService { get; set; }

        private bool showUpdateAllButton = false;
        private int editedItemCount = 0;
        private List<string> editElementEvents = new();
        private bool dense = true;
        private bool hover = true;
        private bool ronly = false;
        private bool canCancelEdit = true;
        private string elementSearchString = "";
        private Element selectedElementItem1 = null;
        private Element selectedElementItem2 = null;
        private Element elementBeforeEdit;
        private HashSet<Element> selectedElementItems1 = new HashSet<Element>();
        private HashSet<Element> selectedElementItems2 = new HashSet<Element>();
        private IEnumerable<Element> Elements = new List<Element>();

        private List<string> editTestEvents = new();
        private string testSearchString = "";
        private Test selectedTestItem1 = null;
        private Test selectedTestItem2 = null;
        private Test testBeforeEdit;
        private HashSet<Test> selectedTestItems1 = new HashSet<Test>();
        private HashSet<Test> selectedTestItems2 = new HashSet<Test>();
        private IEnumerable<Test> Tests = new List<Test>();

        protected override async Task OnInitializedAsync()
        {
            configurationItem = await _rhinoAPIConfiguration.GetConfigurationItemAsync(id);
            if (configurationItem != null)
            {
                Elements = configurationItem.Elements;
                Tests = configurationItem.Tests;
            }

        }

        private void ClearEventLog()
        {
            editElementEvents.Clear();
        }

        private void AddEditionEvent(string message)
        {
            editElementEvents.Add(message);
            StateHasChanged();
        }

        private void ElementBackupItem(object element)
        {
            elementBeforeEdit = new()
            {
                ConfigurationItemId = ((Element)element).ConfigurationItemId,
                ElementName = ((Element)element).ElementName,
                Index = ((Element)element).Index,
            };
            AddEditionEvent($"RowEditPreview event: made a backup of Element {((Element)element).ElementName}");
        }
        private void TestBackupItem(object test)
        {
            testBeforeEdit = new()
            {
                ConfigurationItemId = ((Test)test).ConfigurationItemId,
                TestItem = ((Test)test).TestItem,
                Index = ((Test)test).Index,
            };
            AddEditionEvent($"RowEditPreview event: made a backup of Test {((Test)test).TestItem}");
        }
        private void ElementItemHasBeenCommitted(object element)
        {
            AddEditionEvent($"RowEditCommit event: Changes to Element {((Element)element).ElementName} committed");
        }
        private void TestItemHasBeenCommitted(object test)
        {
            AddEditionEvent($"RowEditCommit event: Changes to Test {((Test)test).TestItem} committed");
        }
        private void ResetElementItemToOriginalValues(object element)
        {
            ((Element)element).ConfigurationItemId = elementBeforeEdit.ConfigurationItemId;
            ((Element)element).ElementName = elementBeforeEdit.ElementName;
            ((Element)element).Index = elementBeforeEdit.Index;
            AddEditionEvent($"RowEditCancel event: Editing of Element {((Element)element).ElementName} cancelled");
        }
        private void ResetTestItemToOriginalValues(object test)
        {
            ((Test)test).ConfigurationItemId = testBeforeEdit.ConfigurationItemId;
            ((Test)test).TestItem = testBeforeEdit.TestItem;
            ((Test)test).Index = testBeforeEdit.Index;
            AddEditionEvent($"RowEditCancel event: Editing of Element {((Test)test).TestItem} cancelled");
        }

        private bool ElementFilterFunc(Element element)
        {
            if (string.IsNullOrWhiteSpace(elementSearchString))
                return true;
            if (element.ElementName.Contains(elementSearchString, StringComparison.OrdinalIgnoreCase))
                return true;
            if ($"{element.Index} {element.Index} {element.Index}".Contains(elementSearchString))
                return true;
            return false;
        }
        private bool TestFilterFunc(Test test)
        {
            if (string.IsNullOrWhiteSpace(testSearchString))
                return true;
            if (test.TestItem.Contains(testSearchString, StringComparison.OrdinalIgnoreCase))
                return true;
            if ($"{test.Index} {test.Index} {test.Index}".Contains(testSearchString))
                return true;
            return false;
        }
        private void ShowElementItemUpdateFeedBack()
        {
            editedItemCount++;
            if (editedItemCount > 0)
                showUpdateAllButton = true;
            else
            {
                showUpdateAllButton = false;
            }
            StateHasChanged();
            Snackbar.Add("Commit Edit saved!");
        }
        private void ShowTestItemUpdateFeedBack()
        {
            editedItemCount++;
            if (editedItemCount > 0)
                showUpdateAllButton = true;
            else
            {
                showUpdateAllButton = false;
            }
            StateHasChanged();
            Snackbar.Add("Commit Edit saved!");
        }
        private async void UpdateConfigurationItem()
        {
            isBusy = true;
            var configurationResponse = new ConfigurationResponse();
            string automationAPIId = null;
            configurationItem.Elements = Elements.ToList();
            configurationItem.Tests = Tests.ToList();
            configurationResponse= await _rhinoAPIConfiguration.UpdateConfigurationsAsync(configurationItem);
            isBusy = false;
            StateHasChanged();


            if (await _storageService.ContainKeyAsync("AutomationAPIId"))
            {
                automationAPIId = await _storageService.GetItemAsync<string>("AutomationAPIId");
            }
            if (configurationResponse.Succeeded)
            {
                _toastService.ShowSuccess(configurationResponse.ResponseMessage);
                _navigationManager.NavigateTo($"/configurations/{automationAPIId}");
            }
            else
            {
                _toastService.ShowError(configurationResponse.ResponseMessage);
            }
        }
    }
}
