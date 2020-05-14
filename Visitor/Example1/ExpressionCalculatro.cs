using System;
using System.Collections.Generic;
using System.Text;

namespace Visitor.Example1
{
    class ExpressionCalculatro 
    {
        public double Result;

        public void Visit(DoubleExpression de)
        {
            Result = de.Value;
        }

        public void Visit(AdditionExpression ae)
        {


        }
    }
}
