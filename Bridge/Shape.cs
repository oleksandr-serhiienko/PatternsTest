using System;
using System.Collections.Generic;
using System.Text;

namespace Bridge
{
    public abstract class Shape
    {
        protected IRender render;
        protected Shape(IRender render)
        {
            this.render = render;
        }
        public abstract void Draw();
        public abstract void Resize(float factor);
    }
}
