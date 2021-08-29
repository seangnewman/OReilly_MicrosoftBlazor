using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OReilly_MicrosoftBlazor.Client.Pages
{
    public partial class Index
    {
        public bool ShowAlert { get; set; } = true;
        public void ToggleAlert()
        => ShowAlert = !ShowAlert;
    }
}
