using System;
using System.Collections.Generic;
using System.Text;

namespace SIngleTone
{
    using System;

    namespace Coding.Exercise
    {
        public class SingletonTester
        {
            public static bool IsSingleton(Func<object> func)
            {
                var obj1 = func.Invoke();
                var obj2 = func.Invoke();
                if (obj1.Equals(obj2))
                    return true;
                else
                    return false;

            }
        }
    }

}
