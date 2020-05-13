using System;
using System.Collections.Generic;
using System.Text;

namespace StateDesignPatterm.Phone
{
    public enum Trigger
    {
        CallDialed,
        HungUp,
        CallConnected, 
        PlacedOnHold,
        TakenOffHold,
        LeftMessage
    }
}
