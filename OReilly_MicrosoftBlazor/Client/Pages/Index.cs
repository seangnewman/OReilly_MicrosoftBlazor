using OReilly_MicrosoftBlazor.Client.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OReilly_MicrosoftBlazor.Client.Pages
{
    public partial class Index
    {
        OReilly_MicrosoftBlazor.Client.Components.DismissableAlert x;
        private DismissableAlert alert;
        public bool ShowAlert { get; set; } = true;
        public void ToggleAlert()
        {
            Console.WriteLine("++++");
            ShowAlert = !ShowAlert;
            //StateHasChanged();
        }
    }
}
