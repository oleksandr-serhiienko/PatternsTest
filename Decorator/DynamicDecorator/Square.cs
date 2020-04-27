using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator.DynamicDecorator
{
    public class Square : Shape
    {
        private float side;

        public Square(float side)
        {
            this.side = side;
        }

        public Square() : this (0.0f)
        {

        }
        public override string AsString()
        {
            return $"A square with side {side}";
        }
    }
}
