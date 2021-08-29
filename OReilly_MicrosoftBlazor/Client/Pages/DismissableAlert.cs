using Microsoft.AspNetCore.Components;

namespace OReilly_MicrosoftBlazor.Client.Pages
{
    public partial class DismissableAlert
    {
        [Parameter]
        public bool Show { get; set; }
        [Parameter]
        public RenderFragment ChildContent { get; set; }
        public void Dismiss()
          => Show = false;
    }
}

