using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter.GenericAdapter
{
    public class Vector<T, D>
        where D:IInteger, new()
    {
        protected T[] data;

        public Vector()
        {
            data = new T[new D().Value];
        }

        public T this[int index]
        {
            get => data[index];
            set => data[index] = value;
        }

        public T X
        {
            get => data[0];
            set => data[0] = value;
        }

 
    }
}
