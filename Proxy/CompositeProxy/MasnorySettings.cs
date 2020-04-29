using System;
using System.Collections.Generic;
using System.Text;

namespace Proxy.CompositeProxy
{
    public class MasnorySettings
    {
        public bool? All
        {
            get 
            {
                if (Pillars == Walls && Walls == Floors) return Pillars;
                else return null;
            }
            set 
            {
                if (!value.HasValue) return;
                Pillars = value.Value;
                Walls = value.Value;
                Floors = value.Value;
            }
         }

        public bool Pillars, Walls, Floors;
    }
}
