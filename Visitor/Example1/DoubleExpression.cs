using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Visitor.Example1
{
    public class DoubleExpression : Expression
    {
        private double value;

        public DoubleExpression(double value)
        {
            this.value = value;
        } 
        public override void Print(StringBuilder sb)
        {
            sb.Append(value);
        }
    }
}
