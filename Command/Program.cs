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
            var ba = new BankAccount();
            var commands = new List<BancAccountCommand>
              {
                new BancAccountCommand(ba, BancAccountCommand.Action.Deposit, 100),
                new BancAccountCommand(ba, BancAccountCommand.Action.Withdraw, 1000)
              };

            Console.WriteLine(ba);

            foreach (var c in commands)
                c.Call();

            Console.WriteLine(ba);

            foreach (var c in Enumerable.Reverse(commands))
                c.Undo();

            Console.WriteLine(ba);

        }
    }
}
