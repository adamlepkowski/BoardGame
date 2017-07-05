using NUnit.Framework;
using NUnit.Framework.Internal;

namespace BoardGame.Tests
{
    [TestFixture]
    public class PieceTests
    {
        [TestCase(Direction.N, Direction.E)]
        [TestCase(Direction.E, Direction.S)]
        [TestCase(Direction.S, Direction.W)]
        [TestCase(Direction.W, Direction.N)]
        public void RotateRight_InitialDirectionInParamters_ShouldRotateToTargetDirectionFromParamters(Direction initialDirection, Direction expectedDirection)
        {
            var piece = new Piece(0, 0, initialDirection);

            piece.RotateRight();

            Assert.AreEqual(expectedDirection, piece.Direction);
        }

        [TestCase(Direction.N, Direction.W)]
        [TestCase(Direction.W, Direction.S)]
        [TestCase(Direction.S, Direction.E)]
        [TestCase(Direction.E, Direction.N)]
        public void RotateLeft_InitialDirectionInParamters_ShouldRotateToTargetDirectionFromParamters(Direction initialDirection, Direction expectedDirection)
        {
            var piece = new Piece(0, 0, initialDirection);

            piece.RotateLeft();

            Assert.AreEqual(expectedDirection, piece.Direction);
        }
    }
}