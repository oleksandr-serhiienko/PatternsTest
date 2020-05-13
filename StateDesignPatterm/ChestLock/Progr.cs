using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Text;

namespace StateDesignPatterm.ChestLock
{
    class Progr
    {
        static Chest Manipulate(Chest chest, Action action, bool havekey) =>
            (chest, action, havekey) switch
            {
                (Chest.Locked, Action.Open, true) => Chest.Open,
                (Chest.Closed, Action.Open, _) => Chest.Open,
                (Chest.Open, Action.Close, true) => Chest.Locked,
                (Chest.Open, Action.Close, false) => Chest.Closed,

                _ => chest
            };
        public static void Main()
        {
            var chest = Chest.Locked;
            Console.WriteLine($"Chest is {chest}");

            chest = Manipulate(chest, Action.Open, true);

        }
    }
}
