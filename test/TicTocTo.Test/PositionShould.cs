using System;
using System.Collections.Generic;
using System.Text;
using TicTocTo.Domain;
using Xunit;

namespace TicTocTo.Test
{
    public class PositionShould
    {
        [Theory]
        [InlineData(PositionType.One,MarkerType.X,PositionState.X)]
        [InlineData(PositionType.Two,MarkerType.O, PositionState.O)]
        public void CanChangeEmptyPosition(
            PositionType pt,
            MarkerType mt,
            PositionState ps)
        {
            var position = new Position(pt);
            position.Mark(mt);

            Assert.True(position.State== ps);
        }

        [Fact]
        public void NotAllowChangeFromXtoO()
        {
            var position = new Position(PositionType.Eight);
            position.Mark(MarkerType.X);
            position.Mark(MarkerType.O);

            Assert.Equal(PositionState.X, position.State);
        }
    }
}
