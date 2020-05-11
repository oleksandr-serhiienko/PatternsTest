using System;
using System.Collections.Generic;
using System.Text;

namespace NullObject
{
    public interface ILog
    {
        public void Info(string msg);

        public void Warn(string msg);
    }
}
