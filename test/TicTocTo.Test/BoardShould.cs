using System;
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
    }
}
