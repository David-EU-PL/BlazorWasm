using BlazorWasm.Services;
using Microsoft.AspNetCore.Components;

namespace BlazorWasm.Pages
{
    public partial class Counter
    {

        private int currentCount = 0;
        private bool _isActive = false;

        [Parameter]
        public string? Header { get; set; }

        [Parameter]
        public bool? IsDeleted { get; set; }

        [SupplyParameterFromQuery (Name = "Header2")]
        public string? Header2 { get; set; }

        [Inject]
        public NavigationManager NavigationManager { get; set; }

        [Inject]
        public IStudentRepo StudentRepo { get; set; }

        private void IncrementCount()
        {
            StudentRepo.Add();
            currentCount++;
        }

        private void ToogleActive()
        {
            _isActive = !_isActive;
        }

        private void GoToHome()
        {
            NavigationManager.NavigateTo("/");
        }
    }
}
