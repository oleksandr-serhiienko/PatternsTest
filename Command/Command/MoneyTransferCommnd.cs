using System;
using System.Collections.Generic;
using System.Text;

namespace Command.Command
{
    public class MoneyTransferCommnd : CompositeBankAccountCommand
    {
        public MoneyTransferCommnd(BankAccount from, BankAccount to, int amount)
        {
            AddRange(new[]
            {
                new BancAccountCommand(from, BancAccountCommand.Action.Withdraw, amount),
                new BancAccountCommand(to, BancAccountCommand.Action.Deposit, amount)
            }) ;        
        }

        public override void Call()
        {
            BancAccountCommand last = null;
            foreach (var cmd in this)
            {
                if (last == null || last.Success)
                {
                    cmd.Call();
                    last = cmd;
                }
                else
                {
                    cmd.Undo();
                    break;
                }
            }
        }
    }
}
