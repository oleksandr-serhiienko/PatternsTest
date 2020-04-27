using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator.DynamicDecorator
{
    public class Square : IShape
    {
        private float side;

        public Square(float side)
        {
            this.side = side;
        }
        public string AsString()
        {
            return $"A square with side {side}";
        }
    }
}
