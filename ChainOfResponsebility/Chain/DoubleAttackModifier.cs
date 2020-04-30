using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResponsebility
{
    public class DoubleAttackModifier : CreatureModifier
    {
        public DoubleAttackModifier(Creature creature) : base(creature)
        {
        }
        public override void Handle()
        {
            Console.WriteLine($"Double {creature.Name}'s attack");
            creature.Atack *= 2;

            base.Handle();
        }
    }
}
