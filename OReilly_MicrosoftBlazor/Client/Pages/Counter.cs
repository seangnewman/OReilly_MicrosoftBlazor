using Microsoft.AspNetCore.Components.Web;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OReilly_MicrosoftBlazor.Client.Pages
{
    public partial class Counter
    {

        private int currentCount = 0;
        private int increment = 1;
        private string backgroundColor = "red-background";
        private bool shouldPreventDefault = true;
        private string outerPos = "Nothing yet";
        private string innerPos = "Nothing yet";
        private DateTime Today { get; set; } = DateTime.Now;

        private void OuterMouseMove(MouseEventArgs e) => outerPos = $"Mouse last at {e.ClientX}x{e.ClientY}";
        private void InnerMouseMove(MouseEventArgs e) => innerPos = $"Mouse last at {e.ClientX}x{e.ClientY}";


        //private void IncrementCount(MouseEventArgs e)
        //{
        //    currentCount += increment;
        //    backgroundColor = (currentCount % 2 == 0) ? "red-background" : "yellow-background";
        //}

        private void IncrementCount()
        {
            Console.WriteLine("++");
            currentCount += increment;
            backgroundColor = (currentCount % 2 == 0) ? "red-background" : "yellow-background";
        }


        private void KeyHandler(KeyboardEventArgs e)
        {
            Console.WriteLine(e.Code);

            if (e.Key == "+")
            {
                increment += 1;
            }

            if (e.Key == "-")
            {
                increment -= 1;
            }
        }

        private void IncrementDate() => Today = Today.AddDays(1);

        private void AutoIncrement()
        {
            var timer = new System.Threading.Timer(
                callback: (_) => {
                    IncrementCount();
                    this.StateHasChanged();
                },
                state: null,
                dueTime: TimeSpan.FromSeconds(1),
                period: TimeSpan.FromSeconds(1)
                );
        }
    }
}
