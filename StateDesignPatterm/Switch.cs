﻿using System;
using System.Collections.Generic;
using System.Text;

namespace StateDesignPatterm
{
    public class Switch
    {
        public State State = new OffState();
        public void On() { State.On(this); }
        public void Off() { State.Off(this); }
    }
}
