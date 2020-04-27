using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator.DynamicDecorator
{
    public class Circle : IShape
    {
        private float radius;

        public Circle(float radius)
        {
            this.radius = radius;
        }

        public void Resize(float factor)
        {
            radius *= factor;
        }

        public string AsString()
        {
            return $"A circle with radius {radius}";
        }
    }
}
