using System;

namespace Momento
{
    class Program
    {
        static void Main(string[] args)
        {
            var ba = new BankAccount(100);
            ba.Deposit(50);
            ba.Deposit(25);
            Console.WriteLine(ba);
            ba.Undo();
            Console.WriteLine(ba);
            ba.Undo();
            Console.WriteLine(ba);
            ba.Redo();
            Console.WriteLine(ba);
        }
    }
}
