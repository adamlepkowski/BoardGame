using NUnit.Framework;

namespace BoardGame.Tests
{
    [TestFixture]
    public class BoardTests
    {
        [Test]
        public void Constructor_PawnPositionIs00N()
        {
            var board = new Board();

            var piece = board.Piece;

            Assert.IsNotNull(board.Piece);
            Assert.AreEqual("0 0 N", piece.CurrentPosition);
        }

        [TestCase("R", "0 0 E")]
        [TestCase("L", "0 0 W")]
        public void MovePiece_CommandProvidedInParameters_PieceShouldMoveToPositionFromParamters(string commands, string expectedPosition)
        {
            var board = new Board();

            board.MovePiece(commands);

            Assert.AreEqual(expectedPosition, board.Piece.CurrentPosition);
        }
    }
}