using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Visitor.Example1
{
    public class DoubleExpression : Expression
    {
        public double Value;

        public DoubleExpression(double value)
        {
            this.Value = value;
        } 

    }
}
