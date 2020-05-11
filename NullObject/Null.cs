using ImpromptuInterface;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Text;

namespace NullObject
{
    class Null<TInterface> : DynamicObject where TInterface : class 
    {
        public static TInterface Instance
        {
            get 
            {
                return new Null<TInterface>().ActLike<TInterface>();
            }
        }

        public override bool TryInvokeMember(InvokeMemberBinder binder, object[] args, out object result)
        {
            result = Activator.CreateInstance(binder.ReturnType);
            return true;
        }
    }
}
