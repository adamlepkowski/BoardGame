using System;

namespace BoardGame
{
    public class Board : IBoard
    {
        private const int Height = 5;
        private const int Width = 5;

        public Board()
        {
            this.Piece = new Piece(new Position(0, 0), Direction.N);
        }

        public IPiece Piece { get; }

        public void MovePiece(string commands)
        {
            foreach (var command in commands.ToUpper())
            {
                switch (command)
                {
                    case 'L':
                        this.Piece.RotateLeft();
                        break;
                    case 'R':
                        this.Piece.RotateRight();
                        break;
                    case 'M':
                        this.Piece.Move(this);
                        break;
                    default:
                        throw new NotSupportedException();
                }
            }
        }

        public bool IsPositionValid(IPosition position)
        {
            if (position == null)
            {
                throw new ArgumentNullException(nameof(position));
            }

            return position.X >= 0 && position.Y >= 0 && position.X < Width && position.Y < Height;
        }
    }
}