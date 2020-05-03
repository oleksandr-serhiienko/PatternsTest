using Command.Command;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Command
{
    class Program
    {
        static void Main(string[] args)
        {
            var from = new BankAccount();
            from.Deposit(100);
            var to = new BankAccount();
            var mtc = new MoneyTransferCommnd(from, to, 100);
            mtc.Call();
            Console.WriteLine(from);
            Console.WriteLine(to);
            mtc.Undo();
            Console.WriteLine(from);
            Console.WriteLine(to);

        }
    }
}
