using System;
using System.Collections.Generic;
using System.Text;

namespace StateDesignPatterm.Phone
{
    public enum State
    {
        OffHook,
        Connecting,
        Connected,
        OnHold
    }
}
