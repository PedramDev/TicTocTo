using System;
using System.Collections.Generic;
using System.Text;
using TicTocTo.Domain;
using Xunit;

namespace TicTocToe.Test
{
    public class GameShould
    {
        [Fact]
        public void HasWinner()
        {
            Player x = new Player();
            Player o = new Player();

            var game = new Game(x, o);


            AddMove(ref game,ref o, MarkerType.O, PositionType.One);
            AddMove(ref game,ref x, MarkerType.X, PositionType.Five);
            AddMove(ref game,ref o, MarkerType.O, PositionType.Two);
            AddMove(ref game,ref x, MarkerType.X, PositionType.Eight);
            AddMove(ref game,ref o, MarkerType.O, PositionType.Three);

            var wins = game.GetWinner();

            Assert.True(wins == GameResult.OWins);
        }

        [Fact]
        public void HasDraw()
        {


            Player x = new Player();
            Player o = new Player();

            var game = new Game(x, o);

            AddMove(ref game,ref o, MarkerType.O, PositionType.One);
            AddMove(ref game,ref x, MarkerType.X, PositionType.Two);
            AddMove(ref game,ref o, MarkerType.O, PositionType.Three);
            AddMove(ref game,ref x, MarkerType.X, PositionType.Four);
            AddMove(ref game,ref o, MarkerType.O, PositionType.Five);
            AddMove(ref game,ref x, MarkerType.X, PositionType.Six);
            AddMove(ref game,ref o, MarkerType.O, PositionType.Seven);
            AddMove(ref game,ref x, MarkerType.X, PositionType.Eight);
            AddMove(ref game,ref o, MarkerType.O, PositionType.Nine);

            var wins = game.GetWinner();

            Assert.True(wins == GameResult.Draw);
        }

        static void AddMove(ref Game game,ref Player p, MarkerType t,PositionType pt)
        {
            var po = new Position(pt);
            po.Mark(t);
            var m = new Move(p, po);
            game.AddMove(m);
        }


        [Fact]
        public void Play()
        {
            Player x = new Player();
            Player o = new Player();

            var game = new Game(x, o);

            var mx1 = new Move(x, new Position(PositionType.One));
            game.AddMove(mx1);
            var mo1 = new Move(o, new Position(PositionType.Five));
            game.AddMove(mo1);


            var mx2 = new Move(x, new Position(PositionType.Two));
            game.AddMove(mx2);
            var mo2 = new Move(o, new Position(PositionType.Eight));
            game.AddMove(mo2);


            var wins = game.GetWinner();

            Assert.True(wins == GameResult.Play);
        }

        [Fact]
        public void Has_3_Move()
        {

            Player x = new Player();
            Player o = new Player();

            var game = new Game(x, o);


            var mx1 = new Move(x, new Position(PositionType.One));
            game.AddMove(mx1);
            var mo1 = new Move(o, new Position(PositionType.Five));
            game.AddMove(mo1);


            var mx2 = new Move(x, new Position(PositionType.Two));
            game.AddMove(mx2);

            Assert.True(game.Moves.Count == 3);
        }
    }
}
