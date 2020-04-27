using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator.DynamicDecorator
{
    public class TransperentShape : IShape
    {
        private IShape shape;
        private float transperacy;

        public TransperentShape(IShape shape, float transparency)
        {
            this.shape = shape;
            this.transperacy = transparency;
        }
        public string AsString()
        {
            return $"{shape.AsString()} has {transperacy} transperacy ";
        }
    }
}
