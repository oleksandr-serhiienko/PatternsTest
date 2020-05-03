using System;
using System.Collections.Generic;
using System.Text;

namespace Command.Command
{
    public class BancAccountCommand : ICommand
    {
        private BankAccount account;

        public enum Action
        { Deposit, Withdraw}

        private Action action;
        private int amount;
        private bool succeeded;

        public BancAccountCommand(BankAccount account, Action action, int amount)
        {
            this.action = action;
            this.account = account;
            this.amount = amount;
        }
        public void Call()
        {
            switch (action)
            {
                case Action.Deposit:
                    account.Deposit(amount);
                    succeeded = true;
                    break;
                case Action.Withdraw:
                    succeeded = account.Withdraw(amount);
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }

        }

        public void Undo()
        {
            if (!succeeded) return;
            switch (action)
            {               
                case Action.Deposit:
                    account.Withdraw(amount);
                    break;
                case Action.Withdraw:
                    account.Deposit(amount);

                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }
    }
}
