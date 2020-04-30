using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResponsebility.Mediator
{
    public class Game
    {
        public event EventHandler<Query> Queries;

        public void PreformQuery(object sender, Query q)
        {
            Queries?.Invoke(sender, q);
        }


    }
}
