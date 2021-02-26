using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TicTacToe.Share;

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

            PlayerX = playerX;
            PlayerO = playerO;

            Board = new Board();
            Moves = new List<Move>();
        }
        public Player PlayerX { get; }
        public Player PlayerO { get; }
        public Board Board { get; private set; }
        public IList<Player> Players { get; private set; }
        public IList<Move> Moves { get; private set; }

        public OperationResult AddMove(Move move)
        {
            if (Moves.Count == 9)
            {
                return OperationResult.BuildFailure("No moves left!");
            }

            if(Moves.Count < 9 && Moves.Count > 0)
            {
                var last = Moves.Last();
                if (last.Player.Id == move.Player.Id)
                {
                    return OperationResult.BuildFailure("Not your turn!");
                }
            }

            var forkResult = Board.Fork(move.Position.Type, move.Player.MarkerType);
            if (forkResult)
            {
                //var position = new Position(move.Position.Type);
                //position.Mark(move.Player.MarkerType);

                Moves.Add(move);

                return OperationResult.BuildSuccess();
            }
            else
            {
                return forkResult;
            }
        }

        public Player GetNextTurn()
        {
            if (Moves.Any())
            {
                var lastPlayer = Moves.Last().Player;
                if(PlayerX == lastPlayer)
                {
                    return PlayerO;
                }
                else
                {
                    return PlayerX;
                }
            }
            else
            {
                return PlayerX;
            }
        }

        public GameResult GetWinner()
        {
            if(Moves.Count < 5)
            {
                return GameResult.Play;
            }

            var xWins = Board.HasAllRow(PositionState.X);
            if (xWins)
            {
                return GameResult.XWins;
            }

            var oWins = Board.HasAllRow(PositionState.O);
            if (oWins)
            {
                return GameResult.OWins;
            }

            return GameResult.Draw;
        }

    }
}
