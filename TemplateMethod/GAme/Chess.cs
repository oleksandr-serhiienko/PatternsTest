using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Text;

namespace TemplateMethod.GAme
{
    public class Chess : Game
    {

        private int turn = 1;
        private int maxTurns = 10;

        public Chess(int numberOfPlayers) : base(2)
        {
        }

        protected override bool HaveWinner => turn == maxTurns;

        protected override int WinningPlayer => currentPlayer;

        protected override void Start()
        {
            Console.WriteLine($"Starting a game of chess with {numberOfPlayers} players");
        }

        protected override void TakeTurn()
        {
            Console.WriteLine($"Turn {turn ++} taek be player {currentPlayer}.");
            currentPlayer = (currentPlayer + 1) % numberOfPlayers;
        }
    }
}
