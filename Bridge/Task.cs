using System;

namespace Coding.Exercise
{
    public abstract class Shape 
    {
        protected IRender render;
        protected Shape(IRender render)
        {
            this.render = render;
        }
        
        public string Name { get; set; }

        public override string ToString()
        {
            return $"Drawing {Name} as {render.WhatToRenderAs}";
        }
    }

    public interface IRender
    {
        string WhatToRenderAs { get; }
    }

    public class VectorRenderer : IRender
    {
        public string WhatToRenderAs => "vector";

    }

    public class RasterRenderer : IRender
    {
        public string WhatToRenderAs => "pixel";

    }


    public class Triangle : Shape
    {
        public Triangle(IRender render) : base(render)
        {
             Name = "Triangle";
        }

    }

    public class Square : Shape
    {
        public Square(IRender render) : base(render)
        {
            Name = "Square";
        }
    }

    public class Test
    {
        public static void Main()
        {
            Console.WriteLine(new Triangle(new RasterRenderer()).ToString()); 
        }
    }
}

