using Adapter.GenericAdapter;
using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter
{
    class GenericValueAdaptor
    {
        static void Main(string[] args)
        {
            var v = new Vector2i(1, 3);
            v[0] = 0;

            var vv = new Vector2i(3,2);

            var result = v + vv;

            var u = Vector3f.Create(1.3f, 4.5f);
            u.ToString();
        }
    }
}
