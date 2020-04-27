using Decorator.DynamicDecorator;
using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator.StaticDecorator
{
    public class ColoredShape<T> : Shape where T : Shape, new()
    {
        private string color;
        T shape = new T();

        public ColoredShape() : this("black")
        {

        }

        public ColoredShape(string color)
        {
            this.color = color;
        }
        public override string AsString()
        {
            return $"{shape.AsString()} has the color {color}";  
        }
    }
}
