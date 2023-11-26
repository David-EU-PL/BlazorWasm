using Microsoft.AspNetCore.Components;

namespace BlazorWasm.Components
{
    public partial class Card
    {
        [Parameter]
        public string Image { get; set; }

        [Parameter]
        public string Title { get; set; }

        [Parameter]
        public string Content { get; set; }

        [Parameter]
        public string BtnText { get; set; }
    }
}
