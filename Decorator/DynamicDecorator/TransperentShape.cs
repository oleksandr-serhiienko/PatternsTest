using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator.DynamicDecorator
{
    public class TransperentShape : Shape
    {
        private Shape shape;
        private float transperacy;

        public TransperentShape(Shape shape, float transparency)
        {
            this.shape = shape;
            this.transperacy = transparency;
        }
        public override string AsString()
        {
            return $"{shape.AsString()} has {transperacy} transperacy ";
        }
    }
}
