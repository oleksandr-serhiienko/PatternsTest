using System;
using System.Collections.Generic;
using System.Runtime.Intrinsics.X86;
using System.Text;

namespace Observer
{
    public class Person
    {
        public void CatchACold()
        {
            Fallsill?.Invoke(this, new FallsillEventArgs { Address = "124 Kirovograd city"});
        }

        public event EventHandler<FallsillEventArgs> Fallsill;
    }
}
