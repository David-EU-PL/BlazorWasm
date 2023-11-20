using Microsoft.AspNetCore.Components.Web;

namespace BlazorWasm.Layout
{
    public partial class MainLayout
    {
        private ErrorBoundary _errorBoundary;
        public static object TopSection = new();
        protected override void OnParametersSet()
        {
            _errorBoundary?.Recover();
        }

    }
}
