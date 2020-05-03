using System;
using System.Collections.Generic;
using System.Text;

namespace Command.Command
{
    public class BankAccount
    {
        private int balance;
        private int overdraftLimit = -500;

        public void Deposit(int amount)
        {
            balance += amount;
            Console.WriteLine($"Deposited {amount}, balance is now {balance}");
        }

        public void Withdraw(int amount)
        {
            if (balance - amount >= overdraftLimit)
            {
                balance -= amount;
                Console.WriteLine($"Withdrew ${amount}, balance is now {balance}");
            }
        }

        public override string ToString()
        {
            return $"{nameof(balance)}: {balance}";
        }
    }
}
