using ChainOfResponsebility.Mediator;
using System;

namespace ChainOfResponsebility
{
    class Program
    {
        static void Main(string[] args)
        {
            //var goblin = new Creature("Goblin", 2, 2);
            //Console.WriteLine(goblin);

            //var root = new CreatureModifier(goblin);

            //root.Add(new NoBonusesModifier(goblin));

            //Console.WriteLine("Lets double goblins attack");
            //root.Add(new DoubleAttackModifier(goblin));
            //root.Add(new IncreasedDefenceModifier(goblin));

            //root.Handle();

            //Console.WriteLine(goblin);

            var game = new Game();
            Mediator.Creature goblin = new Mediator.Creature(game, "Updated", 3, 5);
            Console.WriteLine(goblin);

            using (new Mediator.DoubleAttackModifier(game, goblin))
            {
                Console.WriteLine(goblin);
                using (new IncreaseDefenseModifier(game, goblin))
                {
                    Console.WriteLine(goblin);
                }
            }

            Console.WriteLine(goblin);
        }
    }
}
