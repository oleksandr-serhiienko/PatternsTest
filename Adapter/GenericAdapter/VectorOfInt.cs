using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter.GenericAdapter
{
    public class VectorOfInt<D> : Vector<int, D>
        where D : IInteger, new()
    {
        public VectorOfInt(params int[] values) : base(values)
        {

        }

        public static VectorOfInt<D> operator +
            (VectorOfInt<D> lhs, VectorOfInt<D> rhs)
        {
            var result = new VectorOfInt<D>();
            var dim = new D().Value;
            for (int i = 0; i < dim; i++)
            {
                result[i] = lhs[i] + rhs[i];
            }
            return result;
        }
    }


}
