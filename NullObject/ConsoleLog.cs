using System;
using System.Collections.Generic;
using System.Text;

namespace NullObject
{
    public class ConsoleLog : ILog
    {
        public void Info(string msg)
        {
            Console.WriteLine(msg);
        }

        public void Warn(string msg)
        {
            Console.WriteLine("WARN" + msg);
        }
    }
}
