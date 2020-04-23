using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter.GenericAdapter
{
    public class Vector2i : VectorOfInt<Dimensions.Two>
    {
        public Vector2i(params int[] values) : base(values)
        {

        }

    }
}
