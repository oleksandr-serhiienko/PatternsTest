using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator.DynamicDecorator
{
    public class ColoredShape : IShape
    {

        private IShape shape;
        private string color;

        public ColoredShape(IShape shape, string color)
        {
            this.shape = shape;
            this.color = color;
        }
        public string AsString()
        {
            return $"{shape.AsString()} has the color {color}";
        }
    }
}
