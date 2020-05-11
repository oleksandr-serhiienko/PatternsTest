using System;
using System.Collections.Generic;
using System.Text;

namespace Momento
{
    public class BankAccount
    {
        private int balance;
        public BankAccount(int balance)
        {
            this.balance = balance;
        }

        public Momento Deposit(int amount)
        {
            balance += amount;
            return new Momento(balance);
        }

        public override string ToString()
        {
            return balance.ToString() ;
        }

        public void Restore(Momento m)
        {
            balance = m.Balance;
        }
    }
}
