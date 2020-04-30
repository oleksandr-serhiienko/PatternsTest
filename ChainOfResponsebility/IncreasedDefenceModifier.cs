using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResponsebility
{
    public class IncreasedDefenceModifier : CreatureModifier
    {
        public IncreasedDefenceModifier(Creature creature) : base(creature)
        {
        }

        public override void Handle()
        {

            Console.WriteLine($"Increaseing {creature.Name}'s defence");
            creature.Defense += 1;
            base.Handle();  
        }
    }
}
