using System.Collections.Generic;

namespace TicTocTo.Domain
{
    public class Board
    {
        public Board()
        {
            Positions.Add(new Position
            {
                State = PositionState.Empty,
                Type = PositionType.One
            });
            Positions.Add(new Position
            {
                State = PositionState.Empty,
                Type = PositionType.Two
            });
            Positions.Add(new Position
            {
                State = PositionState.Empty,
                Type = PositionType.Three
            });
            Positions.Add(new Position
            {
                State = PositionState.Empty,
                Type = PositionType.Four
            });
            Positions.Add(new Position
            {
                State = PositionState.Empty,
                Type = PositionType.Five
            });
            Positions.Add(new Position
            {
                State = PositionState.Empty,
                Type = PositionType.Six
            });
            Positions.Add(new Position
            {
                State = PositionState.Empty,
                Type = PositionType.Seven
            });
            Positions.Add(new Position
            {
                State = PositionState.Empty,
                Type = PositionType.Eight
            });
            Positions.Add(new Position
            {
                State = PositionState.Empty,
                Type = PositionType.Nine
            });
        }
        public IList<Position> Positions { get; set; }
    }
}
