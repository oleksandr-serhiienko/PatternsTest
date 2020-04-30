using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResponsebility.Mediator
{
    public class Creature
    {
        private Game game;
        public string Name;
        private int attack, defense;

        public Creature(Game game, string name, int attack, int defense)
        {
            this.game = game;
            Name = name;
            this.attack = attack;
            this.defense = defense;
        }

        public int Attack 
        {
            get
            {
                var q = new Query(Name, Query.Argument.Attack, attack);
                game.PreformQuery(this, q);
                return q.value;
            }
        }

        public int Defense
        {
            get
            {
                var q = new Query(Name, Query.Argument.Defense, defense);
                game.PreformQuery(this, q);
                return q.value;
            }
        }
    }
}
