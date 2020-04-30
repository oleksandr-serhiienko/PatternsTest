using System;

namespace ChainOfResponsebility
{
    class Program
    {
        static void Main(string[] args)
        {
            var goblin = new Creature("Goblin", 2, 2);
            Console.WriteLine(goblin);

            var root = new CreatureModifier(goblin);

            root.Add(new NoBonusesModifier(goblin));

            Console.WriteLine("Lets double goblins attack");
            root.Add(new DoubleAttackModifier(goblin));
            root.Add(new IncreasedDefenceModifier(goblin));

            root.Handle();

            Console.WriteLine(goblin);
        }
    }
}
