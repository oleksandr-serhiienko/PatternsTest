using System;
using System.Collections.Generic;
using System.Text;

namespace Visitor.Example1
{
    public interface IExpressionVisitor
    {
        void Visit(DoubleExpression de);
        void Visit(AdditionExpression ae);
    }
}
