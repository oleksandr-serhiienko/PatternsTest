using Decorator.DynamicDecorator;
using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator.StaticDecorator
{
    public class TransperentShape<T> : Shape where T : Shape, new()
    {
        private float transparency;
        T shape = new T();

        public TransperentShape() : this(0)
        {

        }

        public TransperentShape(float transparency)
        {
            this.transparency = transparency;
        }
        public override string AsString()
        {
            return $"{shape.AsString()} has the transperancy {transparency}";  
        }
    }
}
