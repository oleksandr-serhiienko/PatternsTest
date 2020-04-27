using System;

namespace Decorator.DynamicDecorator
{
    class Program
    {

        static void Main(string[] args)
        {
            var square = new Square(1.23f);
            Console.WriteLine(square.AsString());

            var redSquare = new ColoredShape(square, "red");
            Console.WriteLine(redSquare.AsString());

            var redHalfTransperentSquare = new TransperentShape(redSquare, 0.5f);
            Console.WriteLine(redHalfTransperentSquare.AsString());
        }
    }
}
