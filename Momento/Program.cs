using System;

namespace Momento
{
    class Program
    {
        static void Main(string[] args)
        {
            var ba = new BankAccount(100);
            var m1 = ba.Deposit(50);
            var m2 = ba.Deposit(25);
            Console.WriteLine(ba);
            ba.Restore(m1);
            Console.WriteLine(ba);
            ba.Restore(m2);
            Console.WriteLine(ba);
        }
    }
}
