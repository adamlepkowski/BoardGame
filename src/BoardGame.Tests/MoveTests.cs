using BoardGame.MoveFactory;
using BoardGame.MoveStrategies;
using NUnit.Framework;

namespace BoardGame.Tests
{
    public class MoveTests
    {
        private static readonly object[] MoveTestScenarios =
        {
            new object[] {new MoveNorth(), new Position(3,3), new Position(4,3) },
            new object[] {new MoveEast(), new Position(3,3), new Position(3,4) },
            new object[] {new MoveSouth(), new Position(3,3), new Position(2,3) },
            new object[] {new MoveWest(), new Position(3,3), new Position(3,2) }
        };

        [TestCaseSource(nameof(MoveTestScenarios))]
        public void GetNewPosition__NewPositionFrom(IMove move, IPosition startPosition, IPosition expectedPosition)
        {
            var newPosition = move.GetNewPosition(startPosition);

            Assert.AreEqual(expectedPosition.Y, newPosition.Y);
            Assert.AreEqual(expectedPosition.X, newPosition.X);
        }
    }
}