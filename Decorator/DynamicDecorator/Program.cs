using Decorator.StaticDecorator;
using System;

namespace Decorator.DynamicDecorator
{
    class Program
    {

        static void Main2(string[] args)
        {
            var redSquare = new ColoredShape<Square>();
            Console.WriteLine(redSquare.AsString());

            var circle = new TransperentShape<ColoredShape<Circle>>(3f);
            Console.WriteLine(circle.AsString());
        }
    }
}
