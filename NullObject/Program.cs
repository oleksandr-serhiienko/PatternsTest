using Autofac;
using System;

namespace NullObject
{
    class Program
    {
        static void Main(string[] args)
        {
            var log = Null<ILog>.Instance;
            var ba = new BankAccount(log);
            ba.Deposit(500);
        }
    }
}
