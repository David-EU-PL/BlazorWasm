using BlazorWasm.Services;
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using System.Data;

namespace BlazorWasm.Pages
{
    public partial class JavaScript
    {

        private bool _dialogResult = false;
        private string _currentDate = "";
        private IJSObjectReference _jsModule;

        [Inject]
        public IJSRuntime JSRuntime { get; set; }

        [Inject]
        public ToastrService ToastrService { get; set; }

        protected override async Task OnInitializedAsync()
        {
            _jsModule = await JSRuntime.InvokeAsync<IJSObjectReference>("import", "./scripts/jsTestModule.js");
        }
        private async Task DisplayAlert()
        {
            await JSRuntime.InvokeVoidAsync("alert", "Przykładowa wiadomość");
        }

        private async Task DisplayConfirmDialog()
        {
            _dialogResult = await JSRuntime.InvokeAsync<bool>("confirm", "Czy na pewno chcesz usunąć rekord?");

        }

        private async Task ShowResultJs()
        {
            await JSRuntime.InvokeVoidAsync("addNumberJS", 1, 2);
        }

        [JSInvokable]
        public static int Add(int number1, int number2)
        {
            return number1 + number2;
        }

        private async Task ShowResultCSharp()
        {
            await JSRuntime.InvokeVoidAsync("addNumberCSharp", 11, 22);
        }



        [JSInvokable]
        public static string GetCurrentDate()
        {
            return DateTime.Now.ToString("dd-MM-yyyy");
        }

        private async Task ShowDate()
        {
            _currentDate = await JSRuntime.InvokeAsync<string>("GetCurrentDateCSharp");
        }

        private async Task ShowResultJsModule()
        {
            await _jsModule.InvokeVoidAsync("addNumberJSModule", 1, 12);
        }

        private async Task ShowToastrNotification()
        {
            await ToastrService.ShowInfoMessage("Toastr wywołany w Blazor!");
        }
    }
}
