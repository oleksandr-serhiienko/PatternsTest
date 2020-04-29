using System;
using System.Collections.Generic;
using System.Text;

namespace Proxy.PropertyProxy
{
    public class Creature
    {
        private Property<int> agility { get; set; } = new Property<int>();

        public int Agility 
        { 
            get => agility.Value;
            set => agility.Value = value;
        }
    }
}
