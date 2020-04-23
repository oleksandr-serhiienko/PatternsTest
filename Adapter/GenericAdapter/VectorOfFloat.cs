using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter.GenericAdapter
{
    public class VectorOfFloat<TSelf, D> 
        : Vector<TSelf, float, D>
        where D : IInteger, new()
        where TSelf : Vector<TSelf, float, D>, new()
    {
        public VectorOfFloat(params float[] values) : base(values)
        {

        }
        public VectorOfFloat()
        {

        }

        //public static VectorOfFloat<D> operator +
        //    (VectorOfFloat<D> lhs, VectorOfFloat<D> rhs)
        //{
        //    var result = new VectorOfFloat<D>();
        //    var dim = new D().Value;
        //    for (int i = 0; i < dim; i++)
        //    {
        //        result[i] = lhs[i] + rhs[i];
        //    }
        //    return result;
        //}
    }


}
