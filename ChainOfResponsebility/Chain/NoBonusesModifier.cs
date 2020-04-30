using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResponsebility
{
    public class NoBonusesModifier : CreatureModifier
    {
        public NoBonusesModifier(Creature creature) : base(creature)
        {
        }

        public override void Handle()
        {

        }
    }
}
