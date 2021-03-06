﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Command.Command
{
    public interface ICommand
    {
        void Call();

        void Undo();

        bool Success { get; set; }
    }
}
