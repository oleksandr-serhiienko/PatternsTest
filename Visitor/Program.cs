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

            ep.Visit(e);
            Console.WriteLine(ep);

            var calc = new ExpressionCalculatro();
            calc.Visit(e);
            Console.WriteLine($"{ep} = {calc.Result} ");
        }
    }
}
