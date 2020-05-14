using System;
using System.ComponentModel;
using System.Text;
using Visitor.Example1;

namespace Visitor
{
    class Program
    {
        static void Main(string[] args)
        {
            var e = new AdditionExpression(
                new DoubleExpression(1),
                new AdditionExpression(
                    new DoubleExpression(2), new DoubleExpression(3)
                    ));

            var ep = new ExpressionPrinter();
            var sb = new StringBuilder();
            ep.Print((dynamic)e, sb);
            Console.WriteLine(sb);
        }
    }
}
