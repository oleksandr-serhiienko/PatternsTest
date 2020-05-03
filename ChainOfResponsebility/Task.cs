using System;
using System.Collections.Generic;
using static System.Console;

namespace Coding.Exercise
{
    public class Game
    {
        public IList<Creature> Creatures;

        public event EventHandler<Query> Queries;

        public Game()
        {
            Creatures = new List<Creature>();
        }

        public void PerformQuery(object sender, Query q)
        {
            Queries?.Invoke(sender, q);
        }
    }

    public class Query
    {

        public enum Argument
        {
            Attack, Defense
        }

        public Argument WhatToQuery;

        public int Value; // bidirectional

        public Query(Argument whatToQuery, int value)
        {
            WhatToQuery = whatToQuery;
            Value = value;
        }
    }

    public abstract class Creature : IDisposable
    {
        protected Game game;

        protected readonly int initialAttack;
        protected readonly int initialDefense;

        public Creature(Game game, int initialAttack, int initialDefense)
        {
            this.game = game;
            this.initialAttack = initialAttack;
            this.initialDefense = initialDefense;
        }

        public abstract int Attack { get; }
        public abstract int Defense { get; }

        public override string ToString()
        {
            return $"Creature of Attack {Attack} and Defense {Defense}";
        }

        protected abstract void Handle(object sender, Query q);

        public abstract void Dispose();

    }

    public class Goblin : Creature
    {
        public Goblin(Game game, int initialAttack = 1, int initialDefense = 1) : base(game, initialAttack, initialDefense)
        {
            game.Queries += Handle;
        }

        public override int Attack
        {
            get
            {
                var q = new Query(Query.Argument.Attack, initialAttack);
                game.PerformQuery(this, q);
                return q.Value;
            }
        }

        public override int Defense
        {
            get
            {
                var q = new Query(Query.Argument.Defense, initialDefense);
                game.PerformQuery(this, q);
                return q.Value;
            }
        }

        protected override void Handle(object sender, Query q)
        {
            var thisGoblin = sender as Goblin;

            if (q.WhatToQuery == Query.Argument.Attack)
            {
                q.Value = thisGoblin.initialAttack;
                foreach (var creature in game.Creatures)
                {
                    if (!ReferenceEquals(thisGoblin, creature) &&
                        creature is GoblinKing)
                    {
                        q.Value += 1;
                    }
                }
            }
            else if (q.WhatToQuery == Query.Argument.Defense)
            {

                q.Value = thisGoblin.initialDefense;
                foreach (var creature in game.Creatures)
                {
                    if (!ReferenceEquals(thisGoblin, creature))
                    {
                        q.Value += 1;
                    }
                }
            }
            else
            {
                throw new ArgumentOutOfRangeException(nameof(q.WhatToQuery));
            }
        }

        public override void Dispose()
        {
            game.Queries -= Handle;
        }

        public override string ToString()
        {
            return $"Goblin of Attack {Attack} and Defense {Defense}";
        }
    }

    public class GoblinKing : Goblin
    {
        public GoblinKing(Game game, int initialAttack = 3, int initialDefense = 3) : base(game, initialAttack, initialDefense)
        {
        }

        public override string ToString()
        {
            return $"GoblinKing of Attack {Attack} and Defense {Defense}";
        }

    }
}