using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter.GenericAdapter
{
    public static  class Dimensions
    {
        public class Three : IInteger
        {
            public int Value => 3;
        }

        public class Two : IInteger
        {
            public int Value => 2;
        }
    }
}
