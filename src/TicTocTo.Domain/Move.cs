using System;
using System.Collections.Generic;
using System.Text;

namespace TicTocTo.Domain
{
    public class Move
    {
        public Player Player { get; set; }
        public Position Position { get; set; }
    }
}
