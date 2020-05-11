using System;
using System.Collections.Generic;
using System.Text;

namespace Momento
{
    public class BankAccount
    {
        private int balance;
        private List<Momento> changes = new List<Momento>();
        private int current;
        public BankAccount(int balance)
        {
            this.balance = balance;
            changes.Add(new Momento(balance));
        }

        public Momento Deposit(int amount)
        {
            balance += amount;
            var m = new Momento(balance);
            changes.Add(m);
            ++current;
            return m;
        }

        public override string ToString()
        {
            return balance.ToString() ;
        }

        public Momento Restore(Momento m)
        {
            if (m != null)
            {                
                balance = m.Balance;
                changes.Add(m);
                return m;
            }
            return null;
            
        }

        public Momento Undo()
        {
            if (current != 0)
            {
                var m = changes[--current];
                balance = m.Balance;
                return m;
            }
            return null;
        }

        public Momento Redo()
        {

            if (current + 1 < changes.Count)
            {
                var m = changes[++current];
                balance = m.Balance;
                return m;
            }
            return null;
        }
    }
}
