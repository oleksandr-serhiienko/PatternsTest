using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResponsebility.Mediator
{
    public class DoubleAttackModifier : CreatureModifier
    {
        public DoubleAttackModifier(Game game, Creature creature) : base(game, creature)
        {
        }

        protected override void Handle(object sender, Query q)
        {
            if (q.CreatureName == creature.Name
                && q.WhatToQuery == Query.Argument.Attack)
            q.value *= 2;
        }
    }
}
