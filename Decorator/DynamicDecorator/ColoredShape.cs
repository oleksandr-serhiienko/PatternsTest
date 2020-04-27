using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator.DynamicDecorator
{
    public class ColoredShape : Shape
    {

        private Shape shape;
        private string color;

        public ColoredShape(Shape shape, string color)
        {
            this.shape = shape;
            this.color = color;
        }
        public override string AsString()
        {
            return $"{shape.AsString()} has the color {color}";
        }
    }
}
