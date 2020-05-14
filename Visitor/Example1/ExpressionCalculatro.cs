using System;
using System.Collections.Generic;
using System.Text;

namespace Visitor.Example1
{
    class ExpressionCalculatro : IExpressionVisitor
    {
        public double Result;

        public void Visit(DoubleExpression de)
        {
            Result = de.Value;
        }

        public void Visit(AdditionExpression ae)
        {
            ae.Left.Accept(this);
            var a = Result;
            ae.Right.Accept(this);
            var b = Result;
            Result = a + b;

        }
    }
}
