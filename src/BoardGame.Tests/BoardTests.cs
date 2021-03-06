﻿using NUnit.Framework;

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
            Assert.AreEqual("0 0 N", piece.ToString());
        }

        [TestCase("R", "0 0 E")]
        [TestCase("L", "0 0 W")]
        [TestCase("M", "0 1 N")]
        [TestCase("MRMLMRM", "2 2 E")]
        [TestCase("RMMMLMM", "3 2 N")]
        [TestCase("MMMMMM", "0 4 N")]
        public void MovePiece_CommandProvidedInParameters_PieceShouldMoveToPositionFromParamters(string commands, string expectedPosition)
        {
            var board = new Board();

            board.MovePiece(commands);

            Assert.IsNotNull(board.Piece);
            Assert.AreEqual(expectedPosition, board.Piece.ToString());
        }

        [TestCase(0, 0, ExpectedResult = true)]
        [TestCase(3, 3, ExpectedResult = true)]
        [TestCase(0, 5, ExpectedResult = false)]
        [TestCase(5, 0, ExpectedResult = false)]
        public bool IsPositionValid_PositionProvidedInParameters_Validated(int y, int x)
        {
            IBoard board = new Board();

            return board.IsPositionValid(new Position(y, x));
        }
    }
}