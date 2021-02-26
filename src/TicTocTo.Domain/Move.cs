using System;
using System.Collections.Generic;
using System.Text;

namespace TicTocTo.Domain
{
    public class Move
    {
        public Player Player { get; }
        public Position Position { get; }

        public Move(Player player, Position position)
        {
            Player = player;
            Position = position;
        }
    }
}
