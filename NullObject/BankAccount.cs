using JetBrains.Annotations;
using System;
using System.Collections.Generic;
using System.Text;

namespace NullObject
{
    public class BankAccount
    {
        private ILog log;
        private int balance;

        public BankAccount([CanBeNull]ILog log)
        {
            this.log = log;
        }

        public void Deposit(int amount)
        {
            balance += amount;
            log?.Info($"Depsoited {amount}, balance is {balance}");
        }
    }
}
