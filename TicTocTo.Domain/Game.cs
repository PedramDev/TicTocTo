using System;
using System.Collections.Generic;
using System.Text;

namespace TicTocTo.Domain
{
    public class Game
    {
        public Game(Player playerX, Player playerO)
        {
            Players = new List<Player>
            {
                playerX,
                playerO
            };

            Board = new Board();
            Moves = new List<Move>();
        }
        public Board Board { get; set; }
        public IList<Player> Players { get; set; }
        public IList<Move> Moves { get; set; }

        public void AddMove(Move move)
        {
            Moves.Add(move);
        }

        public Player GetWinner()
        {
            return null;
        }

    }
}
