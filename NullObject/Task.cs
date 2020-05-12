using System;

namespace Coding.Exercise
{
    public interface ILog
    {
        // maximum # of elements in the log
        int RecordLimit { get; }

        // number of elements already in the log
        int RecordCount { get; set; }

        // expected to increment RecordCount
        void LogInfo(string message);
    }

    public class Account
    {
        private ILog log;

        public Account(ILog log)
        {
            this.log = log;
        }

        public void SomeOperation()
        {
            int c = log.RecordCount;
            log.LogInfo("Performing an operation");

        }
    }

    public class NullLog : ILog
    {
        // todo
        public int RecordLimit 
        {
            get { return default(int); }
            set {  }
        }

        public int RecordCount
        {
            get { return default(int); }
            set {}
        }

        public void LogInfo(string message)
        {
        }
    }
}