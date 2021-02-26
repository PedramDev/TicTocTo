namespace TicTocTo.Domain
{
    public enum PositionState
    {
        Empty = 0,
        X = 1,
        O = 2
    }
    public enum PositionType
    {
        One = 1,
        Two,
        Three,
        Four,
        Five,
        Six,
        Seven, 
        Eight,
        Nine
    }
    public class Position
    {
        public PositionState State { get; set; }
        public PositionType Type { get; set; }

    }
}