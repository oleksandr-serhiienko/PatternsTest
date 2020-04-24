using System;
using System.Collections.Generic;
using System.Text;

namespace Bridge
{
    public class VectorRender : IRender
    {
        public void RenderCircle(float radius)
        {
            Console.WriteLine($"Drawing a circle or radius {radius}");
        }
    }
}
