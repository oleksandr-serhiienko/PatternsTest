using System;
using System.Collections.Generic;
using System.Text;

namespace Visitor.Example1
{
    public static class ExpressionPrinter
    {
        public static void Print(Expression e, StringBuilder sb)
        {
            if (e is DoubleExpression de)
            {
                sb.Append(de.Value);
            }
            else if (e is AdditionExpression ae)
            {
                sb.Append("(");
                Print(ae.Left, sb);
                sb.Append("+");
                Print(ae.Right, sb);
                sb.Append(")");
            }
        }
    }
}
