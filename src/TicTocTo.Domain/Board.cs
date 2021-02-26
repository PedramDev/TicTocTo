using System.Collections.Generic;
using System.Linq;
using TicTacToe.Share;

namespace TicTocTo.Domain
{
    public class Board
    {
        public Board()
        {
            Positions.Add(new Position(PositionType.One));
            Positions.Add(new Position(PositionType.Two));
            Positions.Add(new Position(PositionType.Three));
            Positions.Add(new Position(PositionType.Four));
            Positions.Add(new Position(PositionType.Five));
            Positions.Add(new Position(PositionType.Six));
            Positions.Add(new Position(PositionType.Seven));
            Positions.Add(new Position(PositionType.Eight));
            Positions.Add(new Position(PositionType.Nine));
        }
        public IList<Position> Positions { get; set; }

        public OperationResult Fork(PositionType positionType, MarkerType markerType)
        {
            var selectedPos = Positions.Single(x => x.Type == positionType);
            return selectedPos.Mark(markerType);
        }

        public bool HasAllRow(PositionState state)
        {
            //--- horizontal
            var r1 = Positions[0].State == state && Positions[1].State == state && Positions[2].State == state;
            var r2 = Positions[3].State == state && Positions[4].State == state && Positions[5].State == state;
            var r3 = Positions[6].State == state && Positions[7].State == state && Positions[8].State == state;

            //--- vartical
            var r4 = Positions[0].State == state && Positions[3].State == state && Positions[6].State == state;
            var r5 = Positions[1].State == state && Positions[4].State == state && Positions[7].State == state;
            var r6 = Positions[2].State == state && Positions[5].State == state && Positions[8].State == state;

            //--- Diagnal
            var r7 = Positions[0].State == state && Positions[4].State == state && Positions[8].State == state;
            var r8 = Positions[6].State == state && Positions[4].State == state && Positions[2].State == state;

            var result = r1 || r2 || r3 || r4 || r5 || r6 || r7 || r8;

            return result;
        }
    }
}
