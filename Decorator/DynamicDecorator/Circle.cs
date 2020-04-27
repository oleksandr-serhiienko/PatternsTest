using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator.DynamicDecorator
{
    public class Circle : Shape
    {
        private float radius;

        public Circle(float radius)
        {
            this.radius = radius;
        }

        public Circle() : this (0.0f)
        {

        }

        public void Resize(float factor)
        {
            radius *= factor;
        }

        public override string AsString()
        {
            return $"A circle with radius {radius}";
        }
    }
}
