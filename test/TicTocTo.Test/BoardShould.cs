using System.Linq;
using TicTocTo.Domain;
using Xunit;

namespace TicTocTo.Test
{
    public class BoardShould
    {
        [Fact]
        public void Have_9_Positions()
        {
            // Arrange 
            var board = new Board();

            // Act
            var positions = board.Positions;

            // Assert
            Assert.True(positions.Count == 9);
        }

        [Fact]
        public void MarkO()
        {
            var board = new Board();

            var result = board.Fork( PositionType.One,  MarkerType.O);

            var isO = board.Positions.Where(x => x.Type == PositionType.One).First().State;

            Assert.True(isO == PositionState.O);
        }


        [Fact]
        public void Mark_Count_Should_Be_Right()
        {
            var board = new Board();

            board.Fork(PositionType.One, MarkerType.O);

            Assert.True(board.Positions.Count == 9);
        }
    }
}
