using System;

namespace TicTacToe.Share
{
    public enum ErrorType
    {
        Unknown = 0,

        PositionStateIsNotEmpty,

        BoardPositionAlreadyForked,

        MovedAlreadyExisted,
        GameNotPlayerTurn,
        GameNoMoreMovesLeft
    }
}
