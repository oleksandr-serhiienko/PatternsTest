using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace Visitor.Example1
{
    public class ExpressionPrinter 
    {
        public void Print(AdditionExpression ae, StringBuilder sb)
        {
            sb.Append("(");
            Print((dynamic)ae.Left, sb);
            sb.Append("+");
            Print((dynamic)ae.Right, sb);
            sb.Append(")");
        }

        public void Print(DoubleExpression ae, StringBuilder sb)
        {
            sb.Append(ae.Value);
        }
    }
}
