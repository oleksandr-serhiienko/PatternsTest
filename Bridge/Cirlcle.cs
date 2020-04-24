using System;
using System.Collections.Generic;
using System.Text;

namespace Bridge
{
    class Cirlcle : Shape
    {
        private float radius;

        public Cirlcle(IRender render, float radius) : base(render)
        {
            this.radius = radius;
        }

        public override void Draw()
        {
            render.RenderCircle(radius);
        }

        public override void Resize(float factor)
        {
            radius *= factor;
        }
    }
}
