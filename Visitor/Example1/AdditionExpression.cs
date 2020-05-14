using System;
using System.Collections.Generic;
using System.Text;

namespace Visitor.Example1
{
    public class AdditionExpression : Expression
    {
        public Expression Left, Right;

        public AdditionExpression(Expression left, Expression right)
        {
            this.Left = left;
            this.Right = right;
        }

    }
}
