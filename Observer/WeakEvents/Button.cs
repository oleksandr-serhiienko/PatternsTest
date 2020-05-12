using System;
using System.Collections.Generic;
using System.Text;

namespace Observer.WeakEvents
{
    public class Button
    {
        public event EventHandler Clicked;

        public void Fire()
        {
            Clicked?.Invoke(this, EventArgs.Empty);
        }
    }
}
