using NUnit.Framework;

namespace BoardGame.Tests
{
    [TestFixture]
    public class BoardTests
    {
        public void Constructor_PawnPositionIs00N()
        {
            var board = new Board();

            var piece = board.Piece;

            Assert.IsNotNull(board.Piece);
            Assert.AreEqual("0 0 N", piece.CurrentPosition);
        }
    }
}