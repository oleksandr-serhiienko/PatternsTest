using System;
using System.Collections.Generic;
using System.Text;

namespace Bridge
{
    public class RasterRenderer : IRender
    {
        public void RenderCircle(float radius)
        {
            Console.WriteLine($"Drawning pixels for circle with radius {radius}"); 
        }
    }
}
