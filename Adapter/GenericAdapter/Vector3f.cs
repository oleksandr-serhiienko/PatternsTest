using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter.GenericAdapter
{
    public class Vector3f : VectorOfFloat<Vector3f, Dimensions.Three>
    {

        public override string ToString()
        {
            return $"{string.Join(",", data)}";
        }
    }
}
