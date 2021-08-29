using Microsoft.AspNetCore.Components;
using OReilly_MicrosoftBlazor.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace OReilly_MicrosoftBlazor.Client.Pages
{
    public partial class FetchData
    {
       
        private WeatherForecast[] forecasts;

        protected override async Task OnInitializedAsync()
        {
            forecasts = await Http.GetFromJsonAsync<WeatherForecast[]>("WeatherForecast");
        }
    }
}
