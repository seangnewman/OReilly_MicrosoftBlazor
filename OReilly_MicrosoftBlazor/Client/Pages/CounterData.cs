using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OReilly_MicrosoftBlazor.Client.Pages
{
    public class CounterData
    {

        private int count;

        public int Count
        {
            get => this.count;

            set
            {
                if (value != this.count)
                {
                    this.count = value;
                    CountChanged?.Invoke(this.count);
                }
            }
        }

        public Action<int> CountChanged { get; set; }
    }
}

