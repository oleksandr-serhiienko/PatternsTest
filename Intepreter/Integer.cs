using System;
using System.Collections.Generic;
using System.Text;

namespace Intepreter
{
    public class Integer : IElement
    {
        public int Value {get; }

        public Integer(int value)
        {
            this.Value = value;
        }
    }
}
